using ClosedXML.Excel;
using System.Data;

namespace _50pointSol
{
    public partial class Form1 : Form
    {
        const char decimalPoint = '.';

        string FileName = "";

        public Form1()
        {
            InitializeComponent();

            txtVat.Text = "7";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Search Text (FilterText) https://www.csharp-examples.net/dataview-rowfilter/
            // Ex. City = 'Bankok' 
            //     City like '%ban%'
            //     [Business Unit] = 'CPAll'
            //     [Business Unit] like 'CP%'

            try
            {
                DataView dv = dataGridView.DataSource as DataView;
                if (dv != null)
                {
                    dv.RowFilter = txtSearch.Text;
                    lblTotal.Text = $"Total Filtered records: {dataGridView.RowCount}";
                }
                if (String.IsNullOrEmpty(txtSearch.Text))
                {
                    lblTotal.Text = $"Total records: {dataGridView.RowCount}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            // lblTotal.Text = $"Total records:{(int)e.KeyChar}"; // Show key char in number
            if (e.KeyChar == (char)13) // Char 13 = Enter Key
                btnSearch.PerformClick();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excdel Workbook|*.xlsx", Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        Cursor.Current = Cursors.WaitCursor; // Icon Loading on mouse cursor
                        DataTable dt = new DataTable();
                        FileName = ofd.FileName;
                        using (XLWorkbook workbook = new XLWorkbook(ofd.FileName))
                        {
                            bool isFirstRow = true;
                            var rows = workbook.Worksheet(1).RowsUsed();
                            foreach (var row in rows)
                            {
                                if (isFirstRow)
                                {
                                    // Adding collum
                                    foreach (IXLCell cell in row.Cells())
                                        dt.Columns.Add(cell.Value.ToString());
                                    isFirstRow = false;
                                }
                                else
                                {
                                    dt.Rows.Add(); // Add new empty row
                                    int i = 0;
                                    foreach (IXLCell cell in row.Cells())
                                        dt.Rows[dt.Rows.Count - 1][i++] = cell.Value.ToString();
                                }
                            }
                            dataGridView.DataSource = dt.DefaultView;
                            lblTotal.Text = $"Total records: {dataGridView.RowCount}";
                            Cursor.Current = Cursors.Default; // Change Icon Loading to normal mouse cursor
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            DataView dv = dataGridView.DataSource as DataView;
            dv.RowFilter = null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.dataGridView.DataSource = null;

            this.dataGridView.Rows.Clear();

            lblTotal.Text = $"Total records: {dataGridView.RowCount}";
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

            CalculateTotal();
        }

        private void numUnit_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to Exit this application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void numUnits_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateTotal();
        }

        private void numUnits_Scroll(object sender, ScrollEventArgs e)
        {
            CalculateTotal();
        }

    }
}