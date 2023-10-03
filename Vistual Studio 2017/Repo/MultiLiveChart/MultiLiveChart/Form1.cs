using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiLiveChart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // Let's add Students credites
            chartStu.Series["Students"].Points.AddXY("Paul", 120);
            chartStu.Series["Students"].Points.AddXY("John", 150);
            chartStu.Series["Students"].Points.AddXY("Michael", 182);
            chartStu.Series["Students"].Points.AddXY("Davide", 175);

            // Let's add profressor Salary data
            chartProf.Series["Professors"].Points.AddXY("Zack", 250);
            chartProf.Series["Professors"].Points.AddXY("Kitsada", 500);
            chartProf.Series["Professors"].Points.AddXY(" Nut", 480);
            chartProf.Series["Professors"].Points.AddXY(" Mito", 375);

            //Let's show the performance of each student in percentage
            chartPie.Series["Performance"].Points.AddXY("2019", 12);
            chartPie.Series["Performance"].Points.AddXY("2020", 22);
            chartPie.Series["Performance"].Points.AddXY(" 2021", 28);
            chartPie.Series["Performance"].Points.AddXY(" 2020", 35);

            //Let's show each student result each year
            chartLine.Series["Results"].Points.AddXY("2019", 50);
            chartLine.Series["Results"].Points.AddXY("2020", 70);
            chartLine.Series["Results"].Points.AddXY(" 2021", 60);
            chartLine.Series["Results"].Points.AddXY(" 2023", 90);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            try
            {
                iExit = MessageBox.Show("Confirm if you want to exit", "Do you want to exit?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
