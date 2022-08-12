using NoFences.DataModel;
using NoFences.Win32;
using static NoFences.Win32.Native;

namespace NoFences.Windows
{
    internal partial class FenceWindow : Form
    {
        private readonly AppContext ctx;
        private readonly FenceInfo fence;

        public FenceWindow(AppContext ctx, FenceInfo fence)
        {
            InitializeComponent();
            InitializeWindowEffects();
            this.ctx = ctx;
            this.fence = fence;

            Text = fence.Options.Title;
            Location = fence.Location;
            Size = fence.Size;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_SYSCOMMAND when m.WParam.ToInt32() == SC_MAXIMIZE:
                    m.Result = IntPtr.Zero;
                    return;
                case WM_SETFOCUS:
                    SetWindowPos(Handle, HWND_BOTTOM, 0, 0, 0, 0, SWP_NOSIZE | SWP_NOMOVE | SWP_NOACTIVATE);
                    m.Result = IntPtr.Zero;
                    return;
                case WM_NCCALCSIZE:
                    m.Result = IntPtr.Zero;
                    return;
                case WM_NCHITTEST:
                    break;
                case WM_NCMOUSELEAVE:
                    break;
            }

            base.WndProc(ref m);
        }

        private void InitializeWindowEffects()
        {
            WindowEffects.GlueToDesktop(Handle);
            WindowEffects.EnableShadows(Handle);
            WindowEffects.EnableBlur(Handle);
            WindowEffects.HideFromAltTab(Handle);
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