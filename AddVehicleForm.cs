using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleRentalSystem.Models;

namespace VehicleRentalSystem
{
    public partial class AddVehicleForm : Form
    {
        public AddVehicleForm()
        {
            InitializeComponent();
        }

        // Public property to retrieve the created Vehicle
        public Vehicle NewVehicle { get; private set; }

        private void AddVehicleForm_Load(object sender, EventArgs e)
        {
            // Optional: Set default selection if needed
            if (comboType.Items.Count > 0)
            {
                comboType.SelectedIndex = 0;
            }

            comboType.SelectedIndex = 0; // Default to Car
            comboType_SelectedIndexChanged(null, null); // Trigger visibility logic
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Trim and standardize input
            string reg = txtRegNumber.Text.Trim().ToUpper(); // 🔹 NEW: ToUpper for consistency
            string brand = txtBrand.Text.Trim();
            int year = (int)numYear.Value;

            // 🔹 NEW: Basic input validation
            if (string.IsNullOrWhiteSpace(reg) || string.IsNullOrWhiteSpace(brand))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            // 🔹 NEW: Ensure vehicle type is selected
            if (comboType.SelectedItem == null)
            {
                MessageBox.Show("Please select a vehicle type.");
                return;
            }

            // Create appropriate vehicle type based on selection
            if (comboType.SelectedItem.ToString() == "Car")
            {
                int doors = (int)numDoors.Value;
                NewVehicle = new Car(reg, brand, year, doors);
            }
            else if (comboType.SelectedItem.ToString() == "Motorbike")
            {
                bool hasSidecar = chkSidecar.Checked;
                NewVehicle = new Motorbike(reg, brand, year, hasSidecar);
            }
            else
            {
                MessageBox.Show("Invalid vehicle type selected.");
                return;
            }

            // Close the form and return OK result
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void comboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = comboType.SelectedItem.ToString();

            if (selectedType == "Car")
            {
                // Show Car inputs
                numDoors.Visible = true;
                lblDoors.Visible = true;

                // Hide Motorbike inputs
                chkSidecar.Visible = false;
                lblSidecar.Visible = false;
            }
            else if (selectedType == "Motorbike")
            {
                // Show Motorbike inputs
                chkSidecar.Visible = true;
                lblSidecar.Visible = true;

                // Hide Car inputs
                numDoors.Visible = false;
                lblDoors.Visible = false;
            }
        }

    }
}