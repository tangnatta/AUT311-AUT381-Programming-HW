namespace multipage_and_login_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // This code is to display hello guys are you ok? on the form
            lblMessage.Text = "Hello guys are you ok ? ";
        }

        private void btnExit_Click(object sender, EventArgs e)
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

        private void btnSet_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Hello Kosen kmutt Y3. Are you OK?";

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Text has been canceled as requested.";

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide this page

            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}