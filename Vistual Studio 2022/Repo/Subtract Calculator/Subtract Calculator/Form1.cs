namespace Add_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayResult(double result)
        {
            txtResult.Text = result.ToString();
            txtResult.BackColor = result < 0 ? Color.LightPink : Color.LightGreen;
        }

        private double Add(double a, double b)
        {
            double result = a + b;
            return result;
        }
        private double Subtract(double a, double b)
        {
            double result = a - b;
            return result;
        }

        private void ErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //double a = Convert.ToDouble(txtN01.Text);
            //double b = Convert.ToDouble(txtN02.Text);

            //if (a != null && b != null)
            //    Add(a, b);
            //else
            //    ErrorMessage("Not a numeric value!");

            double a = 0d, b = 0d;
            var successA = Double.TryParse(txtN01.Text, out a);
            var successB = Double.TryParse(txtN02.Text, out b);

            if (successA && successB)
            {
                double result = Subtract(a, b);
                DisplayResult(result);
            }
            else
                ErrorMessage("Not a numeric value!");
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