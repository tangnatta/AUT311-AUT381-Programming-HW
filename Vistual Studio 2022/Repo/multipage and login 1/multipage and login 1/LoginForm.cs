namespace multipage_and_login_1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Let’s set first the user id and password.
            String id = txtUID.Text;
            String pass = txtPassword.Text;
            if (id == "5580" && pass == "20235")
            {
                // This code is to display the login form once the Id and password has been identified.
                Form1 f = new Form1();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Password or ID is incorrect.Please try again");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUID.Text = "";
            txtPassword.Text = "";
        }


    }
}

