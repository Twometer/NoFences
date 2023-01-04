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
        public int TitleHeight => trackBarTitleHeight.Value;

        public HeightDialog(int val)
        {
            InitializeComponent();
            trackBarTitleHeight.Value = val;
            UpdateText();
        }

        private void UpdateText()
        {
            labelTitleHeight.Text = trackBarTitleHeight.Value + "px";
        }

        private void trackBarTitleHeight_Scroll(object sender, EventArgs e)
        {
            UpdateText();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            trackBarTitleHeight.Value = 35;
            UpdateText();
        }

        private void HeightDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
