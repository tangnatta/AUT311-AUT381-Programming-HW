namespace WindowsFormSignUp
{
    public partial class Confirmation : Form
    {
        public Confirmation()
        {
            InitializeComponent();
        }

        private void Conformation_Load(object sender, EventArgs e)
        {
            lblFirstName.Text = SignUp.fName;
            lblLastName.Text = SignUp.lName;
            lblEmail.Text = SignUp.emailAddress;

            if (SignUp.sms)
            {
                lblSMS.Text = "✔️";
            }
            if (SignUp.reports)
            {
                lblReports.Text = "✔️";
            }
            if (SignUp.transactions)
            {
                lblTransaction.Text = "✔️";
            }
        }
    }
}
