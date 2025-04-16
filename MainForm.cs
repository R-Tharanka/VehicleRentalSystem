using VehicleRentalSystem.Models;

namespace VehicleRentalSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            AddListBoxHeader();
        }

        private List<Vehicle> vehicles = new List<Vehicle>();

        private void btnLoadVehicles_Click(object sender, EventArgs e)
        {
            listBoxVehicles.Items.Clear();

            vehicles = new List<Vehicle>
            {
                new Car("ABC123", "Toyota", 2021, 4),
                new Car("XYZ987", "Honda", 2020, 2),
                new Motorbike("MTR555", "Yamaha", 2019, false),
                new Motorbike("BIK007", "Harley", 2022, true)
            };

            foreach (var v in vehicles)
            {
                listBoxVehicles.Items.Add(v.GetInfo());
            }
        }

        private void RefreshVehicleList()
        {
            listBoxVehicles.Items.Clear();
            foreach (var v in vehicles)
            {
                listBoxVehicles.Items.Add(v.GetInfo());
            }
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            if (listBoxVehicles.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a vehicle to rent.");
                return;
            }

            Vehicle selectedVehicle = vehicles[listBoxVehicles.SelectedIndex];

            if (selectedVehicle.IsRented)
            {
                MessageBox.Show("This vehicle is already rented.");
            }
            else
            {
                selectedVehicle.Rent();
                RefreshVehicleList();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (listBoxVehicles.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a vehicle to return.");
                return;
            }

            Vehicle selectedVehicle = vehicles[listBoxVehicles.SelectedIndex];

            if (!selectedVehicle.IsRented)
            {
                MessageBox.Show("This vehicle is not rented.");
            }
            else
            {
                selectedVehicle.Return();
                RefreshVehicleList();
            }
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            AddVehicleForm addForm = new AddVehicleForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                vehicles.Add(addForm.NewVehicle);
                RefreshVehicleList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxVehicles.SelectedIndex;
            if (selectedIndex == -1)
            {
                MessageBox.Show("Please select a vehicle to delete.");
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this vehicle?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                vehicles.RemoveAt(selectedIndex);
                RefreshVehicleList();
            }
        }

        private void AddListBoxHeader()
        {
            Label header = new Label();
            header.Text = "RegNumber Brand       Year  Status     Details";
            header.Font = new Font("Consolas", 10);
            header.ForeColor = Color.FromArgb(23, 23, 23);
            header.Location = new Point(listBoxVehicles.Left, listBoxVehicles.Top - 22);
            header.AutoSize = true;
            this.Controls.Add(header);
        }
    }
}
