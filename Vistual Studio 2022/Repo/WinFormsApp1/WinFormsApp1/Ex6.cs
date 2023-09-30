namespace WinFormsApp1
{
    public partial class Ex6 : Form
    {
        public Ex6()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Close Application
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            const string message = "Do you want to close this application?";
            const string caption = "Close";

            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Close Application
            }
            /*
            else if (result == DialogResult.Yes)
            {
                this.Close(); // Also Close Application
            }
            */
        }
    }
}