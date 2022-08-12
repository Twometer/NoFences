using NoFences.Services;

namespace NoFences
{
    internal class AppContext
    {
        public LegacyFenceManager LegacyFenceManager { get; } = new LegacyFenceManager();

        public FenceManager FenceManager { get; } = new FenceManager();
    }
}
