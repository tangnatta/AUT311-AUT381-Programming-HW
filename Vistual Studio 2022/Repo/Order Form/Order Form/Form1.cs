namespace Order_Form
{
    public partial class Form1 : Form
    {
        const char decimalPoint = '.';
        public Form1()
        {
            InitializeComponent();

            txtVat.Text = "7";
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // This code is to cast the sender parameter into a textbox
            // in order to access its text property
            var textbox = sender as TextBox;

            // This code is to determine if the pressed key is a non-numerical value
            //and also that a control key was not pressed. The only non-numerical character
            //allowed is the one stored in the DECIMALPOINT constant.

            bool isHandled = !char.IsDigit(e.KeyChar) &&
            !char.IsControl(e.KeyChar) && !e.KeyChar.Equals(decimalPoint);

            //This code is to evaluate if the key press is considered handled or
            // if the key character is a decimal point and that the textbox
            //already contain a decimal point.

            //lblProduct.Text = isHandled.ToString();

            e.Handled = isHandled || (e.KeyChar.Equals(decimalPoint) &&
            textbox.Text.Contains(decimalPoint));
        }

        private void txtPrice_leave(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void numUnits1_ValueChanged(object sender, EventArgs e)
        {
            // this code line is to assign the result from the numUnits1 Value
            //property cast as an integer to it.
            var units = (int)numUnits1.Value;
            double price = 0;
            Double.TryParse(txtPrice1.Text, out price);
            // the lineTotal is calculated with the formula units*price and stored in a variable called lineTotal declared with the double data type.
            double lineTotal = units * price;
            txtLineTotal1.Text = lineTotal.ToString();

            if (units > 0)
            {
                CalculateTotal();
            }
        }

        private void numUnits2_ValueChanged(object sender, EventArgs e)
        {
            var units = (int)numUnits2.Value;
            double price = 0;
            Double.TryParse(txtPrice2.Text, out price);
            double lineTotal = units * price;
            txtLineTotal2.Text = lineTotal.ToString();

            if (units > 0)
            {
                CalculateTotal();
            }
        }

        private void numUnits3_ValueChanged(object sender, EventArgs e)
        {
            var units = (int)numUnits3.Value;
            double price = 0;
            Double.TryParse(txtPrice3.Text, out price);
            double lineTotal = units * price;
            txtLineTotal3.Text = lineTotal.ToString();

            if (units > 0)
            {
                CalculateTotal();
            }
        }

        private void numUnits4_ValueChanged(object sender, EventArgs e)
        {
            var units = (int)numUnits4.Value;
            double price = 0;
            Double.TryParse(txtPrice4.Text, out price);
            double lineTotal = units * price;
            txtLineTotal4.Text = lineTotal.ToString();

            if (units > 0)
            {
                CalculateTotal();
            }
        }

        private void numUnits5_ValueChanged(object sender, EventArgs e)
        {
            var units = (int)numUnits5.Value;
            double price = 0;
            Double.TryParse(txtPrice5.Text, out price);
            double lineTotal = units * price;
            txtLineTotal5.Text = lineTotal.ToString();

            if (units > 0)
            {
                CalculateTotal();
            }
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            // These are the necessary variables declaration
            double discount, vat, ltot1, ltot2, ltot3, ltot4, ltot5;
            double total, lineTotals, vatTotal;

            int units;
            double price, lineTotal;

            units = (int)numUnits1.Value;
            price = 0;
            Double.TryParse(txtPrice1.Text, out price);
            lineTotal = units * price;
            txtLineTotal1.Text = lineTotal.ToString();

            units = (int)numUnits2.Value;
            price = 0;
            Double.TryParse(txtPrice2.Text, out price);
            lineTotal = units * price;
            txtLineTotal2.Text = lineTotal.ToString();

            units = (int)numUnits3.Value;
            price = 0;
            Double.TryParse(txtPrice3.Text, out price);
            lineTotal = units * price;
            txtLineTotal3.Text = lineTotal.ToString();

            units = (int)numUnits4.Value;
            price = 0;
            Double.TryParse(txtPrice4.Text, out price);
            lineTotal = units * price;
            txtLineTotal4.Text = lineTotal.ToString();

            units = (int)numUnits5.Value;
            price = 0;
            Double.TryParse(txtPrice5.Text, out price);
            lineTotal = units * price;
            txtLineTotal5.Text = lineTotal.ToString();

            // This code is to parse all the values from the textboxes and store
            // the result in the variables we juts created above
            double.TryParse(txtDiscount.Text, out discount);
            double.TryParse(txtVat.Text, out vat);
            double.TryParse(txtLineTotal1.Text, out ltot1);
            double.TryParse(txtLineTotal2.Text, out ltot2);
            double.TryParse(txtLineTotal3.Text, out ltot3);
            double.TryParse(txtLineTotal4.Text, out ltot4);
            double.TryParse(txtLineTotal5.Text, out ltot5);

            //Adding the line totals and subtract the discount,
            //stored the result in the lineTotals variable
            lineTotals = ltot1 + ltot2 + ltot3 + ltot4 + ltot5 - discount;

            // This code is to calculate the Value Added Tax(VAT) amount
            vatTotal = lineTotals * (vat / 100);
            if (vatTotal < 0) vatTotal = 0;
            Math.Round(vatTotal, 2);

            //Calculate the order total by adding the VAT amount to the line totals.
            total = lineTotals + vatTotal;

            //Display the result in the txtVatAmt and txtTotal texboxes.
            // The use of ToString is to assign the double values.
            txtVatAmt.Text = vatTotal.ToString("#.##");
            txtTotal.Text = (total <= 0) ? "FREE" : total.ToString("#.##");
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

        private void txtVat_TextChanged(object sender, EventArgs e)
        {
            double vat = 0;
            double.TryParse(txtVat.Text, out vat);

            CalculateTotal();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            double discount = 0;
            double.TryParse(txtDiscount.Text, out discount);

            CalculateTotal();
        }
    }
}