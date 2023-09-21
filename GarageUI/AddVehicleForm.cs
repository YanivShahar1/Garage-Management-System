
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using GarageLogic.Vehicles;
using GarageLogic.Enums;
using GarageLogic.Info;
using GarageLogic;

namespace GarageUI
{
    public partial class AddVehicleForm : Form
    {
        private int currentTabIndex; // Track the currently displayed tab index.
        private Point vehicleFieldsLocation = new Point(0, 50);
        private Point energySystemFieldsLocation = new Point(300, 50);

        public AddVehicleForm()
        {
            InitializeComponent();
        }
        private void AddVehicleForm_Load(object sender, EventArgs e)
        {
            currentTabIndex = 0;
            buttonBackward.Enabled = false;
            PopulateCarColorListBox();
            PopulateMotorcycleLicenseTypeListBox();
            PopulateYearComboBox();
            panelFuel.Location = energySystemFieldsLocation;
            panelBattery.Location = energySystemFieldsLocation;
            panelTruck.Location = vehicleFieldsLocation;
            panelCar.Location = vehicleFieldsLocation;
            panelMotorcycle.Location = vehicleFieldsLocation;


        }


        private void buttonBackward_Click(object sender, EventArgs e)
        {
            // Navigate to the previous tab if available.
            // Navigate to the previous tab if available.
            if (currentTabIndex > 0)
            {
                currentTabIndex--;
                AddVehicleTabControl.SelectedIndex = currentTabIndex;
            }
            buttonForward.Enabled = true;
            // Update the state of the "Back" button.
            buttonBackward.Enabled = (currentTabIndex > 0);

        }
        private void hideEnergyFields()
        {
            panelBattery.Visible = false;
            panelFuel.Visible = false;
        }
 

        private void buttonForward_Click(object sender, EventArgs e)
        {
            // Navigate to the next tab if available.
            if (currentTabIndex < AddVehicleTabControl.TabCount - 1)
            {
                currentTabIndex++;
                AddVehicleTabControl.SelectedIndex = currentTabIndex;
            }

            // Update the state of the "Forward" button.
            buttonBackward.Enabled = true;
            buttonForward.Enabled = (currentTabIndex < AddVehicleTabControl.TabCount - 1);
            
        }
        private void ShowCarFields()
        {
            // Show data fields specific to Fuel Car
            panelCar.Visible = true;

            // Hide data fields for other vehicle types
            panelTruck.Visible = false;
            panelMotorcycle.Visible = false;
        }
        private void ShowTruckFields()
        {
            panelTruck.Visible = true;


            // Hide data fields for other vehicle types
            panelCar.Visible = false;
            panelMotorcycle.Visible = false;
        }
        private void ShowMotorcycleFields()
        {
            // Show data fields specific to Fuel Car
            panelMotorcycle.Visible = true;
            // Hide data fields for other vehicle types
            panelTruck.Visible = false;
            panelCar.Visible = false;
        }

        private void radioButtonMotorcycle_CheckedChanged(object sender, EventArgs e)
        {
            hideEnergyFields();
            ShowMotorcycleFields();
            if (radioButtonElectricMotorcycle.Checked)
            {
                ShowBatteryEnergyFields();
            }
            else if (radioButtonFuelMotorcycle.Checked)
            {
                ShowFuelEnergyFields();
            }
        }

        private void radioButtonTruck_CheckedChanged(object sender, EventArgs e)
        {
            hideEnergyFields();
            ShowTruckFields();
            if (radioButtonFuelTruck.Checked)
            {
                ShowFuelEnergyFields();
            }
          

        }

        private void radioButtonCar_CheckedChanged(object sender, EventArgs e)
        {
            hideEnergyFields();
            ShowCarFields();
            if (radioButtonElectricCar.Checked)
            {
                ShowBatteryEnergyFields();
            }
            else if (radioButtonFuelCar.Checked)
            {
                ShowFuelEnergyFields();
            }

        }

        private void PopulateCarColorListBox()
        {
            List<string> colors = Car.GetAvailableColors();
            comboBoxCarColor.DataSource = colors;
        }
        private void PopulateMotorcycleLicenseTypeListBox()
        {
            List<string> licenseTypes = Motorcycle.GetAvailableLicenseType();
            comboBoxMotorcycleLicenseType.DataSource = licenseTypes;
        }
        private void PopulateYearComboBox()
        {
            int currentYear = DateTime.Now.Year;
            for (int year = 1990; year <= currentYear; year++)
            {
                comboBoxYear.Items.Add(year);
            }

            // Set the default selected year to the current year
            comboBoxYear.SelectedItem = currentYear;
        }

        private void AddVehicleTabControl_Selected(object sender, TabControlEventArgs e)
        {
            int selectedIndex = AddVehicleTabControl.SelectedIndex;

            // Update forward and backward buttons based on the selected index
            if (selectedIndex == 0)
            {
                // First tab selected, disable backward button
                buttonBackward.Enabled = false;
                buttonForward.Enabled = true;
            }
            else if (selectedIndex == AddVehicleTabControl.TabCount - 1)
            {
                // Last tab selected, disable forward button
                buttonBackward.Enabled = true;
                buttonForward.Enabled = false;
            }
            else
            {
                // Middle tab selected, enable both buttons
                buttonBackward.Enabled = true;
                buttonForward.Enabled = true;
            }

            currentTabIndex = selectedIndex; 

        }

        private void radioButtonFuelCar_CheckedChanged(object sender, EventArgs e)
        {
            ShowFuelEnergyFields();
            numericUpDownFuelLevel.Maximum = (decimal)FuelCar.MaxFuelCapacityLiters;
            numericUpDownFuelLevel.Increment = 1m;


        }

        private void radioButtonElectricCar_CheckedChanged(object sender, EventArgs e)
        {
            ShowBatteryEnergyFields();
            numericUpDownBatteryLevel.Maximum = (decimal)ElectricCar.MaxBatteryCapacityKWh; ;
            numericUpDownBatteryLevel.Increment = 0.1m;

        }

        private void radioButtonFuelMotorcycle_CheckedChanged(object sender, EventArgs e)
        {
            ShowFuelEnergyFields();
            numericUpDownFuelLevel.Maximum = (decimal)FuelMotorcycle.MaxFuelCapacityLiters;
            numericUpDownFuelLevel.Increment = 0.1m;

        }

        private void ShowFuelEnergyFields()
        {
            panelBattery.Visible = false;

            panelFuel.Visible = true;
            

        }
        private void ShowBatteryEnergyFields()
        {
            panelFuel.Visible = false;

            panelBattery.Visible = true;

        }

        private void radioButtonElectricMotorcycle_CheckedChanged(object sender, EventArgs e)
        {
            ShowBatteryEnergyFields();

            numericUpDownFuelLevel.Maximum = (decimal)ElectricMotorcycle.MaxBatteryCapacityKWh;
            numericUpDownFuelLevel.Increment = 0.1m;
        }

        private void radioButtonFuelTruck_CheckedChanged(object sender, EventArgs e)
        {
            ShowFuelEnergyFields();
            numericUpDownFuelLevel.Maximum = (decimal)FuelTruck.MaxFuelCapacityLiters;
            numericUpDownFuelLevel.Increment = 1m;

        }
        private float getCurrentEnergyLevel()
        {
            return 2.2f;
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                eVehicleType selectedType = getSelectedVehicleType();

                VehicleInfo vehicleInfo = getVehicleInfo();
                OwnerInfo ownerInfo = getOwnerInfo();

                Vehicle vehicle = VehicleFactory.CreateVehicle(selectedType);
                float energyLevel = getCurrentEnergyLevel();
                // Configure the vehicle using a builder pattern
                VehicleBuilder builder = VehicleFactory.CreateBuilder(selectedType, vehicle);
                builder.WithVehicleInfo(vehicleInfo);

                if (vehicle is Car)
                {
                    CarBuilder carBuilder = builder as CarBuilder;
                    if (carBuilder != null)
                    {
                        carBuilder.WithColor(Car.eColor.Blue)
                                   .WithNumberOfDoors(Car.eNumberOfDoors.Four);
                    }
                }

                else if (vehicle is Motorcycle)
                {
                    MotorcycleBuilder motorcycleBuilder = builder as MotorcycleBuilder;
                    if (motorcycleBuilder != null)
                    {
                        motorcycleBuilder.WithLicenseType(Motorcycle.eMotorcycleLicenseType.A1);
                    }
                }
                else if (vehicle is Truck)
                {
                    TruckBuilder truckBuilder = builder as TruckBuilder;
                    if (truckBuilder != null)
                    {
                        truckBuilder.WithCargoVolume(22f);
                    }
                }

                // Build the vehicle
                vehicle = builder.Build();

                // Add the vehicle to your garage management system or do other processing
                // ...

                // Clear the form or perform other post-addition actions
                clearForm();
            }
            catch (Exception ex)
            {
                // Handle any exceptions or validation errors here
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private VehicleInfo getVehicleInfo()
        {
            string model = getModelName();
            int year = getVehicleYear();
            string licenseNumber = getLicenseNumber();
            return new VehicleInfo(model, year, licenseNumber);

        }
        private int getVehicleYear()
        {
            string selectedYearString = comboBoxYear.SelectedItem as string;
            if (!string.IsNullOrEmpty(selectedYearString) && int.TryParse(selectedYearString, out int selectedYear))
            {
                return selectedYear;
            }
            else
            {
                throw new ArgumentException("Invalid year input. Please enter a valid year.");
            }
        }
        private string getModelName()
        {
            string modelName = textBoxModelName.Text.Trim(); // Get the text from the TextBox and remove leading/trailing whitespace.

            if (string.IsNullOrWhiteSpace(modelName))
            {
                
                throw new ArgumentException("Model name cannot be empty.");
            }

            return modelName; 
        }

        private string getLicenseNumber()
        {
            string licenseNumber = textBoxLicenseNumber.Text;
            return licenseNumber;
        }
        private OwnerInfo getOwnerInfo()
        {
            string name = getOwnerFullName();
            string phoneNumber = getOwnerPhoneNumber();
            return new OwnerInfo(name, phoneNumber);
        }
        private string getOwnerFullName()
        {
            return GetNonEmptyTextBoxInput(textBoxOwnerFullName, "Owner name");
        }
        private string getOwnerPhoneNumber()
        {
            return GetNonEmptyTextBoxInput(textBoxOwnerPhoneNumber, "Phone number");
        }

        private string GetNonEmptyTextBoxInput(TextBox textBox, string inputName)
        {
            string inputValue = textBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(inputValue))
            {
                throw new ArgumentException($"{inputName} cannot be empty.");
            }

            return inputValue;
        }

        private eVehicleType getSelectedVehicleType()
        {
            eVehicleType selectedType;

            if (fuelCarChecked())
            {
                selectedType = eVehicleType.FuelCar;
            }
            else if (electricCarChecked())
            {
                selectedType = eVehicleType.ElectricCar;
            }
            else if (fuelMotorcycleChecked())
            {
                selectedType = eVehicleType.FuelMotorcycle;
            }
            else if (electricMotorcycleChecked())
            {
                selectedType = eVehicleType.ElectricMotorcycle;
            }
            else if (fuelTruckChecked())
            {
                selectedType = eVehicleType.FuelTruck;
            }
            else
            {
                throw new InvalidOperationException("No vehicle type selected.");
            }

            return selectedType;
        }

        private bool fuelCarChecked()
        {
            return radioButtonCar.Checked && radioButtonFuelCar.Checked;
        }
        private bool electricCarChecked()
        {
            return radioButtonCar.Checked && radioButtonElectricCar.Checked;
        }
        private bool electricMotorcycleChecked()
        {
            return radioButtonMotorcycle.Checked && radioButtonElectricMotorcycle.Checked;
        }
        private bool fuelMotorcycleChecked()
        {
            return radioButtonMotorcycle.Checked && radioButtonFuelMotorcycle.Checked;
        }
        private bool fuelTruckChecked()
        {
            return radioButtonTruck.Checked && radioButtonFuelTruck.Checked;
        }

        private void textBoxLicenseNumber_Leave(object sender, EventArgs e)
        {
            string licenseNumber = textBoxLicenseNumber.Text;

            // Perform validation (you can replace this with your own validation logic)
            if (string.IsNullOrWhiteSpace(licenseNumber))
            {
                // Invalid input, display an error message
                MessageBox.Show("License number cannot be empty.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Set focus back to the TextBox
                textBoxLicenseNumber.Focus();
            }
            else
            {
                // Valid input
            }
        }
    }
}
