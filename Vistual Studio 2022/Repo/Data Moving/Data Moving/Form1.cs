namespace Data_Moving
{
    public partial class Form1 : Form
    {
        string[] cars = { "Honda", "Volvo", "Toyota", "Mustang", "Mitsubishi", "Nissan", "BMV", "Peugeo", "Ford", "Benz" };

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < cars.Length; i++)
            {

                lstCars.Items.Add(cars[i]);
            }
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

        private void btnMoveFor_Click(object sender, EventArgs e)
        {
            lstSelectedCars.Items.Clear();
            foreach (string car in lstCars.SelectedItems)
            {
                lstSelectedCars.Items.Add(car);
            }
        }

        private void btnMoveWhile_Click(object sender, EventArgs e)
        {
            lstSelectedCars.Items.Clear();
            int index = 0;
            while (index < lstCars.SelectedItems.Count)
            {
                lstSelectedCars.Items.Add(lstCars.SelectedItems[index]);
                index++;
            }
        }
    }
}