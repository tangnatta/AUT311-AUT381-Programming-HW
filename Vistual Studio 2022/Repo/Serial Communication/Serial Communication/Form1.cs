namespace Serial_Communication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            foreach (string port in SerialPort.GetPortNames())
            {
                cbbPort.Items.Add(port);
            }
        }
    }
}