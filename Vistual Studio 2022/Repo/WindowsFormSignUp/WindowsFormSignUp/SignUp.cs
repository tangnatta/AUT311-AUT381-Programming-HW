using System.Net.Mail;

namespace WindowsFormSignUp
{
    public partial class SignUp : Form
    {
        public static string fName;
        public static string lName;
        public static string emailAddress;
        public static Boolean sms;
        public static Boolean reports;
        public static Boolean transactions;

        Confirmation c = new Confirmation();

        public SignUp()
        {
            InitializeComponent();
        }

        private static bool IsValidEmail(string email)
        {
            try
            {
                var emailAddress = new MailAddress(email);
                return emailAddress.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                // Show Error dialog
                MessageBox.Show(
                            "Please Enter every feild",
                            "Error",
                            MessageBoxButtons.OK,
                            //MessageBoxIcon.Information  // for Information
                            //MessageBoxIcon.Question // for Question
                            //MessageBoxIcon.Warning // for Warning  
                            MessageBoxIcon.Error // for Error 
                );
                return;
            }
            if (!IsValidEmail(txtEmail.Text))
            {
                // Show Error dialog
                MessageBox.Show(
                            "Please Enter correct email",
                            "Error",
                            MessageBoxButtons.OK,
                            //MessageBoxIcon.Information  // for Information
                            //MessageBoxIcon.Question // for Question
                            //MessageBoxIcon.Warning // for Warning  
                            MessageBoxIcon.Error // for Error 
                );
                return;
            }
            fName = txtFirstName.Text;
            lName = txtLastName.Text;
            emailAddress = txtEmail.Text;

            c.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            // Application.Exit();
        }

        private void chkSMS_CheckedChanged(object sender, EventArgs e)
        {
            sms = chkSMS.Checked;
            if (chkSMS.Checked)
            {
                lblSMSMessage.Text = "Service Changes may Apply for SMS.";
            }
            else
            {
                lblSMSMessage.Text = "............................";
            }
        }

        private void chkReports_CheckedChanged(object sender, EventArgs e)
        {
            reports = chkReports.Checked;
        }

        private void chkTransactions_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTransactions.Checked)
            {
                transactions = true;
                lblTransactionMessage.Text = "Service Changes may Apply for Transactions.";
            }
            else
            {
                transactions = false;
                lblTransactionMessage.Text = "............................";
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}