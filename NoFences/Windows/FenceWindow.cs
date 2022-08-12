using NoFences.DataModel;

namespace NoFences.Windows
{
    internal partial class FenceWindow : Form
    {
        private readonly AppContext ctx;
        private readonly FenceInfo fence;

        public FenceWindow(AppContext ctx, FenceInfo fence)
        {
            InitializeComponent();
            this.ctx = ctx;
            this.fence = fence;

            Text = fence.Options.Title;
            Location = fence.Location;
            Size = fence.Size;
        }

        private void FenceWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }

        private void FenceWindow_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data?.GetDataPresent(DataFormats.FileDrop) == false || fence.Options.Locked)
                return;
 
            switch (fence.Mode)
            {
                case FenceMode.ShortcutBased:
                    e.Effect = DragDropEffects.Link;
                    break;
                case FenceMode.Owning:
                    e.Effect = DragDropEffects.Move;
                    break;
                case FenceMode.Mirroring:
                    e.Effect = DragDropEffects.None;
                    break;
            }
        }

        private void SaveFence()
        {
            ctx.FenceManager.SaveFence(fence);
        }
    }
}