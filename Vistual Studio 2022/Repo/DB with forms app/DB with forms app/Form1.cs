using ClosedXML.Excel;
using System.Data;

namespace DB_with_forms_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Search Text (FilterText) https://www.csharp-examples.net/dataview-rowfilter/
            // Ex. City = 'Bankok' 
            //     City like '%ban%'

            try
            {
                DataView dv = dataGridView.DataSource as DataView;
                if (dv != null)
                    dv.RowFilter = txtSearch.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excdel Workbook|*.xlsx", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor; // Icon Loading on mouse cursor
                    DataTable dt = new DataTable();
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
                        lblTotal.Text = $"Total records:{dataGridView.RowCount}";
                        Cursor.Current = Cursors.Default; // Change Icon Loading to normal mouse cursor
                    }
                }
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            DataView dv = dataGridView.DataSource as DataView;
            dv.RowFilter = null;
        }
    }
}