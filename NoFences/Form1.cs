using NoFences.Win32;
using System;
using System.Drawing;
using System.Windows.Forms;
using static NoFences.Win32.WindowUtil;

namespace NoFences
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            DropShadow.ApplyShadows(this);
            BlurUtil.EnableBlur(Handle);
            WindowUtil.HideFromAltTab(Handle);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0083)
            {
                m.Result = IntPtr.Zero;
                return;
            }

            if (m.Msg == WM_SETFOCUS)
            {
                SetWindowPos(Handle, HWND_BOTTOM, 0, 0, 0, 0, SWP_NOSIZE | SWP_NOMOVE | SWP_NOACTIVATE);
            }
            else
            {
                base.WndProc(ref m);
            }

            if (MouseButtons == MouseButtons.Right || lockedToolStripMenuItem.Checked)
                return;


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

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            e.Graphics.Clear(Color.Transparent);
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.Black)), ClientRectangle);
            var font = new Font(Font.FontFamily, 17);
            var measure = e.Graphics.MeasureString(Text, font);
            e.Graphics.DrawString(Text, font, Brushes.White, new PointF(Width / 2 - measure.Width / 2, 15));            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
