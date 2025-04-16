using VehicleRentalSystem.Models;


namespace VehicleRentalSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private List<Vehicle> vehicles = new List<Vehicle>();

        private void btnLoadVehicles_Click(object sender, EventArgs e)
        {
            // Clear existing items
            listBoxVehicles.Items.Clear();

            // Create and add vehicles
            vehicles = new List<Vehicle>
    {
        new Car("ABC123", "Toyota", 2021, 4),
        new Car("XYZ987", "Honda", 2020, 2),
        new Motorbike("MTR555", "Yamaha", 2019, false),
        new Motorbike("BIK007", "Harley", 2022, true)
    };

            // Display info in listBox
            foreach (var v in vehicles)
            {
                listBoxVehicles.Items.Add(v.GetInfo());
            }
        }
    }
}
