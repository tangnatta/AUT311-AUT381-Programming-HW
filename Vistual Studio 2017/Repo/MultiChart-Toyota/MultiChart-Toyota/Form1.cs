using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiChart_Toyota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chartEmName.Series["EmployerName"].Points.AddXY("Paul", 2);
            chartEmName.Series["EmployerName"].Points.AddXY("John", 3);
            chartEmName.Series["EmployerName"].Points.AddXY("Michael", 4);
            chartEmName.Series["EmployerName"].Points.AddXY("Davide", 1);

            chartCountry.Series["Country"].Points.AddXY("Japan", 2600000);
            chartCountry.Series["Country"].Points.AddXY("USA", 1700000);
            chartCountry.Series["Country"].Points.AddXY("China", 600000);
            chartCountry.Series["Country"].Points.AddXY("India", 500000);
            chartCountry.Series["Country"].Points.AddXY("Germany", 600000);
            chartCountry.Series["Country"].Points.AddXY("France", 700000);
            chartCountry.Series["Country"].Points.AddXY("Italy", 800000);
            chartCountry.Series["Country"].Points.AddXY("Spain", 900000);
            chartCountry.Series["Country"].Points.AddXY("Canada", 1000000);
            chartCountry.Series["Country"].Points.AddXY("Brazil", 1100000);
            chartCountry.Series["Country"].Points.AddXY("Russia", 1200000);

            chartTimeRev.Series["TimeRev"].Points.AddXY("2015", 12500000);
            chartTimeRev.Series["TimeRev"].Points.AddXY("2016", 13800000);
            chartTimeRev.Series["TimeRev"].Points.AddXY("2017", 14400000);
            chartTimeRev.Series["TimeRev"].Points.AddXY("2018", 15900000);
            chartTimeRev.Series["TimeRev"].Points.AddXY("2019", 16300000);
            chartTimeRev.Series["TimeRev"].Points.AddXY("2020", 17700000);
            chartTimeRev.Series["TimeRev"].Points.AddXY("2021", 18600000);
            chartTimeRev.Series["TimeRev"].Points.AddXY("2022", 19100000);
            chartTimeRev.Series["TimeRev"].Points.AddXY("2022", 19900000);

            chartEmSal.Series["Paul"].Points.AddXY("2015", 100000);
            chartEmSal.Series["John"].Points.AddXY("2015", 150000);
            chartEmSal.Series["Michael"].Points.AddXY("2015", 250000);
            chartEmSal.Series["Davide"].Points.AddXY("2015", 60000);
            chartEmSal.Series["Paul"].Points.AddXY("2016", 120000);
            chartEmSal.Series["John"].Points.AddXY("2016", 170000);
            chartEmSal.Series["Michael"].Points.AddXY("2016", 300000);
            chartEmSal.Series["Davide"].Points.AddXY("2016", 80000);
            chartEmSal.Series["Paul"].Points.AddXY("2017", 150000);
            chartEmSal.Series["John"].Points.AddXY("2017", 200000);
            chartEmSal.Series["Michael"].Points.AddXY("2017", 350000);
            chartEmSal.Series["Davide"].Points.AddXY("2017", 100000);
            chartEmSal.Series["Paul"].Points.AddXY("2018", 180000);
            chartEmSal.Series["John"].Points.AddXY("2018", 250000);
            chartEmSal.Series["Michael"].Points.AddXY("2018", 400000);
            chartEmSal.Series["Davide"].Points.AddXY("2018", 120000);
            chartEmSal.Series["Paul"].Points.AddXY("2019", 200000);
            chartEmSal.Series["John"].Points.AddXY("2019", 300000);
            chartEmSal.Series["Michael"].Points.AddXY("2019", 450000);
            chartEmSal.Series["Davide"].Points.AddXY("2019", 150000);
            chartEmSal.Series["Paul"].Points.AddXY("2020", 250000);
            chartEmSal.Series["John"].Points.AddXY("2020", 350000);
            chartEmSal.Series["Michael"].Points.AddXY("2020", 500000);
            chartEmSal.Series["Davide"].Points.AddXY("2020", 200000);
            chartEmSal.Series["Paul"].Points.AddXY("2021", 300000);
            chartEmSal.Series["John"].Points.AddXY("2021", 400000);
            chartEmSal.Series["Michael"].Points.AddXY("2021", 550000);
            chartEmSal.Series["Davide"].Points.AddXY("2021", 250000);
            chartEmSal.Series["Paul"].Points.AddXY("2022", 350000);
            chartEmSal.Series["John"].Points.AddXY("2022", 450000);
            chartEmSal.Series["Michael"].Points.AddXY("2022", 600000);
            chartEmSal.Series["Davide"].Points.AddXY("2022", 300000);
            chartEmSal.Series["Paul"].Points.AddXY("2023", 380000);
            chartEmSal.Series["John"].Points.AddXY("2023", 480000);
            chartEmSal.Series["Michael"].Points.AddXY("2023", 630000);
            chartEmSal.Series["Davide"].Points.AddXY("2023", 330000);

            chartFuRev.Series["TimeRev"].Points.AddXY("2024", 20200000);
            chartFuRev.Series["TimeRev"].Points.AddXY("2025", 21900000);
            chartFuRev.Series["TimeRev"].Points.AddXY("2026", 22600000);
            chartFuRev.Series["TimeRev"].Points.AddXY("2027", 23700000);
            chartFuRev.Series["TimeRev"].Points.AddXY("2028", 24200000);
            chartFuRev.Series["TimeRev"].Points.AddXY("2029", 25100000);
            chartFuRev.Series["TimeRev"].Points.AddXY("2030", 26400000);
            chartFuRev.Series["TimeRev"].Points.AddXY("2031", 27600000);
            chartFuRev.Series["TimeRev"].Points.AddXY("2032", 28700000);
            chartFuRev.Series["TimeRev"].Points.AddXY("2033", 29300000);
            chartFuRev.Series["TimeRev"].Points.AddXY("2034", 30200000);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            chartEmName.Series["EmployerName"].Points.Clear();
            chartEmName.Series["EmployerName"].Points.AddXY("Paul", 2);
            chartEmName.Series["EmployerName"].Points.AddXY("John", 3);
            chartEmName.Series["EmployerName"].Points.AddXY("Michael", 4);
            chartEmName.Series["EmployerName"].Points.AddXY("Davide", 1);

            chartCountry.Series["Country"].Points.Clear();
            chartCountry.Series["Country"].Points.AddXY("Japan", 2600000);
            chartCountry.Series["Country"].Points.AddXY("USA", 1700000);
            chartCountry.Series["Country"].Points.AddXY("China", 600000);
            chartCountry.Series["Country"].Points.AddXY("India", 500000);
            chartCountry.Series["Country"].Points.AddXY("Germany", 600000);
            chartCountry.Series["Country"].Points.AddXY("France", 700000);
            chartCountry.Series["Country"].Points.AddXY("Italy", 800000);
            chartCountry.Series["Country"].Points.AddXY("Spain", 900000);
            chartCountry.Series["Country"].Points.AddXY("Canada", 1000000);
            chartCountry.Series["Country"].Points.AddXY("Brazil", 1100000);
            chartCountry.Series["Country"].Points.AddXY("Russia", 1200000);

            chartTimeRev.Series["TimeRev"].Points.Clear();
            chartTimeRev.Series["TimeRev"].Points.AddXY("2015", 12500000);
            chartTimeRev.Series["TimeRev"].Points.AddXY("2016", 13800000);
            chartTimeRev.Series["TimeRev"].Points.AddXY("2017", 14400000);
            chartTimeRev.Series["TimeRev"].Points.AddXY("2018", 15900000);
            chartTimeRev.Series["TimeRev"].Points.AddXY("2019", 16300000);
            chartTimeRev.Series["TimeRev"].Points.AddXY("2020", 17700000);
            chartTimeRev.Series["TimeRev"].Points.AddXY("2021", 18600000);
            chartTimeRev.Series["TimeRev"].Points.AddXY("2022", 19100000);
            chartTimeRev.Series["TimeRev"].Points.AddXY("2022", 19900000);

            chartEmSal.Series["Paul"].Points.Clear();
            chartEmSal.Series["John"].Points.Clear();
            chartEmSal.Series["Michael"].Points.Clear();
            chartEmSal.Series["Davide"].Points.Clear();
            chartEmSal.Series["Paul"].Points.AddXY("2015", 100000);
            chartEmSal.Series["John"].Points.AddXY("2015", 150000);
            chartEmSal.Series["Michael"].Points.AddXY("2015", 250000);
            chartEmSal.Series["Davide"].Points.AddXY("2015", 60000);
            chartEmSal.Series["Paul"].Points.AddXY("2016", 120000);
            chartEmSal.Series["John"].Points.AddXY("2016", 170000);
            chartEmSal.Series["Michael"].Points.AddXY("2016", 300000);
            chartEmSal.Series["Davide"].Points.AddXY("2016", 80000);
            chartEmSal.Series["Paul"].Points.AddXY("2017", 150000);
            chartEmSal.Series["John"].Points.AddXY("2017", 200000);
            chartEmSal.Series["Michael"].Points.AddXY("2017", 350000);
            chartEmSal.Series["Davide"].Points.AddXY("2017", 100000);
            chartEmSal.Series["Paul"].Points.AddXY("2018", 180000);
            chartEmSal.Series["John"].Points.AddXY("2018", 250000);
            chartEmSal.Series["Michael"].Points.AddXY("2018", 400000);
            chartEmSal.Series["Davide"].Points.AddXY("2018", 120000);
            chartEmSal.Series["Paul"].Points.AddXY("2019", 200000);
            chartEmSal.Series["John"].Points.AddXY("2019", 300000);
            chartEmSal.Series["Michael"].Points.AddXY("2019", 450000);
            chartEmSal.Series["Davide"].Points.AddXY("2019", 150000);
            chartEmSal.Series["Paul"].Points.AddXY("2020", 250000);
            chartEmSal.Series["John"].Points.AddXY("2020", 350000);
            chartEmSal.Series["Michael"].Points.AddXY("2020", 500000);
            chartEmSal.Series["Davide"].Points.AddXY("2020", 200000);
            chartEmSal.Series["Paul"].Points.AddXY("2021", 300000);
            chartEmSal.Series["John"].Points.AddXY("2021", 400000);
            chartEmSal.Series["Michael"].Points.AddXY("2021", 550000);
            chartEmSal.Series["Davide"].Points.AddXY("2021", 250000);
            chartEmSal.Series["Paul"].Points.AddXY("2022", 350000);
            chartEmSal.Series["John"].Points.AddXY("2022", 450000);
            chartEmSal.Series["Michael"].Points.AddXY("2022", 600000);
            chartEmSal.Series["Davide"].Points.AddXY("2022", 300000);
            chartEmSal.Series["Paul"].Points.AddXY("2023", 380000);
            chartEmSal.Series["John"].Points.AddXY("2023", 480000);
            chartEmSal.Series["Michael"].Points.AddXY("2023", 630000);
            chartEmSal.Series["Davide"].Points.AddXY("2023", 330000);

            chartFuRev.Series["TimeRev"].Points.Clear();
            chartFuRev.Series["TimeRev"].Points.AddXY("2024", 20200000);
            chartFuRev.Series["TimeRev"].Points.AddXY("2025", 21900000);
            chartFuRev.Series["TimeRev"].Points.AddXY("2026", 22600000);
            chartFuRev.Series["TimeRev"].Points.AddXY("2027", 23700000);
            chartFuRev.Series["TimeRev"].Points.AddXY("2028", 24200000);
            chartFuRev.Series["TimeRev"].Points.AddXY("2029", 25100000);
            chartFuRev.Series["TimeRev"].Points.AddXY("2030", 26400000);
            chartFuRev.Series["TimeRev"].Points.AddXY("2031", 27600000);
            chartFuRev.Series["TimeRev"].Points.AddXY("2032", 28700000);
            chartFuRev.Series["TimeRev"].Points.AddXY("2033", 29300000);
            chartFuRev.Series["TimeRev"].Points.AddXY("2034", 30200000);
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
