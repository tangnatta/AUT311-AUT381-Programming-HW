namespace Ex7
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> Countries2Language =
                     new Dictionary<string, string>{
                                                {"UK", "London, Manchester, Birmingham"},
                                                {"USA", "Chicago, New York, Washington"},
                                                {"India", "Mumbai, New Delhi, Pune"}
                                                };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setlblMessage();
            cboCountry.Items.Add("Unknown");
            cboCountry.Items.Add("Sweden");
            cboCountry.Items.Add("Norway");
            cboCountry.Items.Add("Finland");
            cboCountry.Items.Add("Great Britain");
            cboCountry.Items.Add("USA");
            cboCountry.Items.Add("Thailand");
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
        }

        private void chkActiviate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActiviate.Checked == true)
            {
                btnCheckGender.Enabled = true;
                rbnFemale.Enabled = true;
                rbnMale.Enabled = true;
            }
            else
            {
                btnCheckGender.Enabled = false;
                rbnFemale.Enabled = false;
                rbnMale.Enabled = false;
            }
        }

        private void rbnMale_CheckedChanged(object sender, EventArgs e)
        {
            setlblMessage();
        }

        private void rbnFemale_CheckedChanged(object sender, EventArgs e)
        {
            setlblMessage();
        }

        private void btnCheckGender_Click(object sender, EventArgs e)
        {
            setlblMessage();
        }

        private void setlblMessage()
        {
            if (rbnMale.Checked == true)
            {
                lblMessage.Text = "Selected gender: Male";
            }
            else if (rbnFemale.Checked == true)
            {
                lblMessage.Text = "Selected gender: Female";
            }
            else
            {
                lblMessage.Text = "No gender selected";
            }
        }

        private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboCountry.SelectedIndex)
            {
                case 1:
                    lblLanguage.Text = "Language: Swendish";
                    lblLanguage.BackColor = Color.LightGreen;
                    break;

                case 2:
                    lblLanguage.Text = "Language: Norwegian";
                    lblLanguage.BackColor = Color.LightSkyBlue;
                    break;

                case 3:
                    lblLanguage.Text = "Language: Finnish";
                    lblLanguage.BackColor = Color.LightYellow;
                    break;

                case 4:
                    lblLanguage.Text = "Language: UK English";
                    lblLanguage.BackColor = Color.LightGoldenrodYellow;
                    break;

                case 5:
                    lblLanguage.Text = "Language: USA English";
                    lblLanguage.BackColor = Color.LightSalmon;
                    break;

                case 6:
                    lblLanguage.Text = "Language: Thai";
                    lblLanguage.BackColor = Color.LightSeaGreen;
                    break;

                default:
                    lblLanguage.Text = "Language: Unspecified";
                    lblLanguage.BackColor = Color.LightPink;
                    break;

            }
        }

        private void cboCountry_TextUpdate(object sender, EventArgs e)
        {
            switch (cboCountry.Text)
            {
                case "Sweden":
                    lblLanguage.Text = "Language: Swendish";
                    lblLanguage.BackColor = Color.LightGreen;
                    break;

                case "Norway":
                    lblLanguage.Text = "Language: Norwegian";
                    lblLanguage.BackColor = Color.LightSkyBlue;
                    break;

                case "Finland":
                    lblLanguage.Text = "Language: Finnish";
                    lblLanguage.BackColor = Color.LightYellow;
                    break;

                case "Great Britain":
                    lblLanguage.Text = "Language: UK English";
                    lblLanguage.BackColor = Color.LightGoldenrodYellow;
                    break;

                case "USA":
                    lblLanguage.Text = "Language: USA English";
                    lblLanguage.BackColor = Color.LightSalmon;
                    break;

                case "Thailand":
                    lblLanguage.Text = "Language: Thai";
                    lblLanguage.BackColor = Color.LightSeaGreen;
                    break;

                default:
                    lblLanguage.Text = "Language: Unspecified";
                    lblLanguage.BackColor = Color.LightPink;
                    break;
            }
        }
    }
}