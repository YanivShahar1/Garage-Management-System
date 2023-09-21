using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GarageUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddVehicleButton_Click(object sender, EventArgs e)
        {
            // Create a new thread to open the Add Vehicle form
            Thread addVehicleThread = new Thread(OpenAddVehicleForm);
            addVehicleThread.Start();
        }
        private void OpenAddVehicleForm()
        {
            // Create an instance of the AddVehicleForm
            AddVehicleForm addVehicleForm = new AddVehicleForm();

            // Show the AddVehicleForm as a dialog (blocking interaction with the main form)
            DialogResult result = addVehicleForm.ShowDialog();

            // Optionally, you can handle the result if needed
            if (result == DialogResult.OK)
            {
                // Handle the user's actions after closing the AddVehicleForm
                // For example, you can retrieve data entered by the user.
            }
        }
    }
}
