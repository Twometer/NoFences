using NoFences.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static NoFences.Win32.WindowUtil;

namespace NoFences
{
    public partial class FenceWindow : Form
    {
        private Font titleFont;
        private Font iconFont;

        public FenceWindow()
        {
            InitializeComponent();
            DropShadow.ApplyShadows(this);
            BlurUtil.EnableBlur(Handle);
            WindowUtil.HideFromAltTab(Handle);

            var family = new FontFamily("Segoe UI");
            titleFont = new Font(family, 17);
            iconFont = new Font(family, 10);

            AllowDrop = true;
        }

        protected override void WndProc(ref Message m)
        {
            // Remove border
            if (m.Msg == 0x0083)
            {
                m.Result = IntPtr.Zero;
                return;
            }

            // Prevent maximize
            if ((m.Msg == WM_SYSCOMMAND) && m.WParam.ToInt32() == SC_MAXIMIZE)
            {
                m.Result = IntPtr.Zero;
                return;
            }

            // Prevent foreground
            if (m.Msg == WM_SETFOCUS)
            {
                SetWindowPos(Handle, HWND_BOTTOM, 0, 0, 0, 0, SWP_NOSIZE | SWP_NOMOVE | SWP_NOACTIVATE);
                return;
            }

            // Other messages
            base.WndProc(ref m);

            // If not locked and using the left mouse button
            if (MouseButtons == MouseButtons.Right || lockedToolStripMenuItem.Checked)
                return;

            // Then, allow dragging and resizing
            if (m.Msg == WM_NCHITTEST)
            {
                if ((int)m.Result == HTCLIENT)     // drag the form
                    m.Result = (IntPtr)HTCAPTION;

                var pt = PointToClient(new Point(m.LParam.ToInt32()));
                if (pt.X < 10 && pt.Y < 10)
                    m.Result = new IntPtr(HTTOPLEFT);
                else if (pt.X > (Width - 10) && pt.Y < 10)
                    m.Result = new IntPtr(HTTOPRIGHT);
                else if (pt.X < 10 && pt.Y > (Height - 10))
                    m.Result = new IntPtr(HTBOTTOMLEFT);
                else if (pt.X > (Width - 10) && pt.Y > (Height - 10))
                    m.Result = new IntPtr(HTBOTTOMRIGHT);
                else if (pt.Y > (Height - 10))
                    m.Result = new IntPtr(HTBOTTOM);
                else if (pt.X < 10)
                    m.Result = new IntPtr(HTLEFT);
                else if (pt.X > (Width - 10))
                    m.Result = new IntPtr(HTRIGHT);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private const int titleHeight = 35;
        private const int titleOffset = 3;
        private const int itemWidth = 70;
        private const int itemPadding = 15;
        private const float shadowDist = 1.5f;

        private List<string> files = new List<string>();

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            e.Graphics.Clear(Color.Transparent);
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.Black)), ClientRectangle);

            var measure = e.Graphics.MeasureString(Text, titleFont);
            e.Graphics.DrawString(Text, titleFont, Brushes.White, new PointF(Width / 2 - measure.Width / 2, titleOffset));

            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(50, Color.Black)), new RectangleF(0, 0, Width, titleHeight));

            var x = 15;
            foreach (var file in files)
            {
                RenderFile(e.Graphics, file, x, 15);
                x += itemWidth + itemPadding;
            }
        }

        private void RenderFile(Graphics g, string file, int x, int y)
        {
            var icon = Icon.ExtractAssociatedIcon(file);
            var name = Path.GetFileNameWithoutExtension(file);

            g.DrawIcon(icon, x + itemWidth / 2 - icon.Width / 2, y+ titleHeight);
            var size = g.MeasureString(name, iconFont);
            g.DrawString(name, iconFont, new SolidBrush(Color.FromArgb(180, 15, 15, 15)), new PointF(x + shadowDist + itemWidth / 2 - size.Width / 2, y + icon.Height + 5 + shadowDist+ titleHeight));
            g.DrawString(name, iconFont, Brushes.White, new PointF(x + itemWidth / 2 - size.Width / 2, y + icon.Height + 5+ titleHeight));
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Refresh();
        }

        private void FenceWindow_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Move;
        }

        private void FenceWindow_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
                if (File.Exists(file))
                this.files.Add(file);
            Refresh();
        }
    }
}
