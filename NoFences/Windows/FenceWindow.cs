namespace NoFences.Windows
{
    public partial class FenceWindow : Form
    {
        public FenceWindow()
        {
            InitializeComponent();
        }

        private void FenceWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }
    }
}