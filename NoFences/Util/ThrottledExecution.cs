using System;
using System.Threading.Tasks;

namespace NoFences.Util
{
    public class ThrottledExecution
    {
        private TimeSpan delay;

        private DateTime lastExecution = DateTime.Now;

        private TimeSpan TimeSinceLastExecution => DateTime.Now - lastExecution;

        private volatile bool isAwaiting;

        public ThrottledExecution(TimeSpan delay)
        {
            this.delay = delay;
        }

        public async void Run(Action action)
        {
            if (TimeSinceLastExecution > delay)
                action.Invoke();
            else if (!isAwaiting)
            {
                isAwaiting = true;
                while (TimeSinceLastExecution < delay)
                {
                    await Task.Delay((int)(delay.TotalMilliseconds - TimeSinceLastExecution.TotalMilliseconds));
                    action.Invoke();
                }
                isAwaiting = false;
            }
            lastExecution = DateTime.Now;
        }

    }
}
