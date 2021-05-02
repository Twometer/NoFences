using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoFences
{
    public partial class HeightDialog : Form
    {
        public int TitleHeight => trackBar1.Value;

        public HeightDialog(int val)
        {
            InitializeComponent();
            trackBar1.Value = val;
            UpdateText();
        }

        private void UpdateText()
        {
            label1.Text = trackBar1.Value + "px";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            UpdateText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            trackBar1.Value = 35;
            UpdateText();
        }

        private void HeightDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
