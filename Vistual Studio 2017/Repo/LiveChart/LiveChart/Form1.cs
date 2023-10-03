using LiveCharts; //must add
using LiveCharts.Wpf; // must add
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveChart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            revenueBindingSource.DataSource = new List<Revenue>();
            cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                // We will initialize the Cartesian Chart then add data to the cartesian chart to show each revenue by year
                Title = "Month",
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep","Oct","Nov","Dec" }
            });
            cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Revenue",
                LabelFormatter = value => value.ToString("C")
            });
            cartesianChart1.LegendLocation = LiveCharts.LegendLocation.Right;

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // initialise the data
            cartesianChart1.Series.Clear();
            // The series collecction here is used to set data for Cartesian Charts, Because we need to get the value
            //from the data siurce, then take the vakue of the nontth by year
            SeriesCollection series = new SeriesCollection();
            var years = (from o in revenueBindingSource.DataSource as List<Revenue>
                         select new { Year = o.Year }).Distinct();
            foreach (var year in years)
            {
                List<Double> values = new List<double>();
                for (int month = 1; month <= 12; month++)
                {
                    double value = 0;
                    var data = from o in revenueBindingSource.DataSource as List<Revenue>
                               where o.Year.Equals(year.Year) && o.Month.Equals(month)
                               orderby o.Month ascending
                               select new { o.Value, o.Month };
                    if (data.SingleOrDefault() != null)
                        value = data.SingleOrDefault().Value;
                    values.Add(value);
                }
                series.Add(new LineSeries()
                {
                    Title = year.Year.ToString(),
                    Values = new ChartValues<double>(values)
                });
            }
            cartesianChart1.Series = series;
        }
    }
}
