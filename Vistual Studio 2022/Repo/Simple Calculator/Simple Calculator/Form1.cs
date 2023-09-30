using System.Data;

namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        double value;
        string soperator;
        bool check;

        public Form1()
        {
            InitializeComponent();
        }

        private void PNumber(object sender, EventArgs e)
        {
            if ((soperator == "*") || (soperator == "+") || (soperator == "-") || (soperator == "/"))
            {
                if (check)
                {
                    check = false;
                    txtResult.Text = "0";
                }
            }
            Button b = sender as Button;
            if (txtResult.Text == "0")
                txtResult.Text = b.Text;
            else
                txtResult.Text += b.Text;

        }

        private void POperator(object sender, EventArgs e)
        {
            Button b = sender as Button;
            value = double.Parse(txtResult.Text);
            soperator = b.Text;
            txtResult.Text += b.Text;
            check = true;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            value = 0;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            value = 0;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                switch (soperator)
                {
                    case "+":
                        txtResult.Text = (value + double.Parse(txtResult.Text)).ToString();
                        break;
                    case "-":
                        txtResult.Text = (value - double.Parse(txtResult.Text)).ToString();
                        break;
                    case "*":
                        txtResult.Text = (value * double.Parse(txtResult.Text)).ToString();
                        break;
                    case "/":
                        txtResult.Text = (value / double.Parse(txtResult.Text)).ToString();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double ComputeStringToValue(string MathString)
        {
            string value = new DataTable().Compute(MathString, null).ToString();

            return Convert.ToDouble(value);
        }

        private void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtBox.Text = ComputeStringToValue(txtBox.Text).ToString();
            }
        }
    }
}