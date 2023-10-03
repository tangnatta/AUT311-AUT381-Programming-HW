using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace Arduino_Com
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Object[] baudRates = { 110, 300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 38400, 57600, 115200, 128000, 256000 };

            try
            {
                cbbBaudRate.Items.AddRange(baudRates);
                cbbBaudRate.SelectedIndex = 6;

                string[] ports = SerialPort.GetPortNames();
                Array.Sort(ports);
                cbbPort.Items.AddRange(ports);
                cbbPort.SelectedIndex = 0;
            }
            catch
            {
            }
        }

        private void cbbPort_MouseClick(object sender, MouseEventArgs e)
        {
            cbbPort.Items.Clear();
            try
            {
                string[] ports = SerialPort.GetPortNames();
                Array.Sort(ports);
                cbbPort.Items.AddRange(ports);
            }
            catch
            {
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();

            try
            {
                serialPort1.PortName = cbbPort.Text;
                serialPort1.BaudRate = Convert.ToInt16(cbbBaudRate.Text);
                serialPort1.Open();

                btnOn.Enabled = true;
                btnOff.Enabled = true;
                btnClose.Enabled = true;
                btnOpen.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();

            btnOn.Enabled = false;
            btnOff.Enabled = false;
            btnClose.Enabled = false;
            btnOpen.Enabled = true;
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("a");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error writing to Arduino", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("A");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error writing to Arduino", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
            Application.Exit();
        }

        private string DispString;

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(25);

            DispString = serialPort1.ReadExisting();

            this.Invoke(new EventHandler(DisplayText));
        }

        private void DisplayText(object sender, EventArgs e)
        {
            txtRecData.AppendText(DispString);
            string[] value = DispString.Split(new string[] { ","}, StringSplitOptions.None);
            lblTemp.Text = value[0] + "°C";
            lblHum.Text = value[1] + "%";
        }
    }
}
