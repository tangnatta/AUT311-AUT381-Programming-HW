namespace Table_with_Excel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Rows.Add("64020012", "Natta", "Sunit", "addr", "1/1/2001", "6654545454");
        }

        private void MeExit()
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to Exit", "Save DataGridView", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MeExit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MeExit();
        }

        private void iDelete()
        {
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            iDelete();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iDelete();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtStudentID.Text, txtFirstname.Text, txtSurname.Text, txtBirthday.Text, txtMobileNo.Text); ;
        }

        private void iReset()
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
            }

            int numRows = dataGridView1.Rows.Count;

            for (int i = 0; i < numRows; i++)
            {
                try
                {
                    int max = dataGridView1.Rows.Count - 1;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[max]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("All rows are delete; " + ex, "DataGridView Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            //dataGridView1.Rows.Clear();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iReset();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            iReset();
        }

        //private void iSave()
        //{
        //    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
        //    Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
        //    Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
        //    //Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];

        //    app.Visible = true;
        //    //worksheet = workbook.Sheets["Sheet1"];
        //    //worksheet = workbook.ActiveSheet;
        //    worksheet.Name = "Exported from gridview";
        //    for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
        //    {
        //        worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
        //    }
        //    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
        //    {
        //        for (int j = 0; j < dataGridView1.Columns.Count; j++)
        //        {
        //            worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
        //        }
        //    }
        //}

        private void iSave()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Output.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dataGridView1.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[dataGridView1.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }

                            File.WriteAllLines(sfd.FileName, outputCsv);
                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            iSave();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iSave();
        }

        Bitmap bitmap;

        private void btnPrint_Click(object sender, EventArgs e)
        {
            int height = dataGridView1.Height;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height + 2 * dataGridView1.RowTemplate.Height;
            bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            dataGridView1.Height = height;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}