
namespace GarageUI
{
    partial class AddVehicleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonCar = new System.Windows.Forms.RadioButton();
            this.radioButtonTruck = new System.Windows.Forms.RadioButton();
            this.radioButtonMotorcycle = new System.Windows.Forms.RadioButton();
            this.panelCar = new System.Windows.Forms.Panel();
            this.EnergyTypeCar = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonElectricCar = new System.Windows.Forms.RadioButton();
            this.radioButtonFuelCar = new System.Windows.Forms.RadioButton();
            this.comboBoxCarColor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMotorcycle = new System.Windows.Forms.Panel();
            this.panelEnergyTypeMotorcycle = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.radioButtonElectricMotorcycle = new System.Windows.Forms.RadioButton();
            this.radioButtonFuelMotorcycle = new System.Windows.Forms.RadioButton();
            this.comboBoxMotorcycleLicenseType = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.VehicleOptionsPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxLicenseNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.OwnerInfoPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxOwnerPhoneNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxOwnerFullName = new System.Windows.Forms.TextBox();
            this.LicenseNumberPanel = new System.Windows.Forms.Panel();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxModelName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.InvalidLicenseNumberLabel = new System.Windows.Forms.Label();
            this.AddVehicleTabControl = new System.Windows.Forms.TabControl();
            this.OwnerInfoTabPage = new System.Windows.Forms.TabPage();
            this.VehicleInfoTabPage = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelTruck = new System.Windows.Forms.Panel();
            this.cargoVolumeLabel = new System.Windows.Forms.Label();
            this.checkBoxDangerousSubstances = new System.Windows.Forms.CheckBox();
            this.panelEnergyTypeTruck = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.radioButtonFuelTruck = new System.Windows.Forms.RadioButton();
            this.panelBattery = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panelFuel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonBackward = new System.Windows.Forms.Button();
            this.buttonForward = new System.Windows.Forms.Button();
            this.numericUpDownFuelLevel = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBatteryLevel = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panelCar.SuspendLayout();
            this.EnergyTypeCar.SuspendLayout();
            this.panelMotorcycle.SuspendLayout();
            this.panelEnergyTypeMotorcycle.SuspendLayout();
            this.VehicleOptionsPanel.SuspendLayout();
            this.OwnerInfoPanel.SuspendLayout();
            this.LicenseNumberPanel.SuspendLayout();
            this.AddVehicleTabControl.SuspendLayout();
            this.OwnerInfoTabPage.SuspendLayout();
            this.VehicleInfoTabPage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelTruck.SuspendLayout();
            this.panelEnergyTypeTruck.SuspendLayout();
            this.panelBattery.SuspendLayout();
            this.panelFuel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFuelLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBatteryLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(303, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Vehicle";
            // 
            // radioButtonCar
            // 
            this.radioButtonCar.AutoSize = true;
            this.radioButtonCar.Location = new System.Drawing.Point(206, 12);
            this.radioButtonCar.Name = "radioButtonCar";
            this.radioButtonCar.Size = new System.Drawing.Size(69, 29);
            this.radioButtonCar.TabIndex = 0;
            this.radioButtonCar.TabStop = true;
            this.radioButtonCar.Text = "Car";
            this.radioButtonCar.UseVisualStyleBackColor = true;
            this.radioButtonCar.CheckedChanged += new System.EventHandler(this.radioButtonCar_CheckedChanged);
            // 
            // radioButtonTruck
            // 
            this.radioButtonTruck.AutoSize = true;
            this.radioButtonTruck.Location = new System.Drawing.Point(319, 12);
            this.radioButtonTruck.Name = "radioButtonTruck";
            this.radioButtonTruck.Size = new System.Drawing.Size(87, 29);
            this.radioButtonTruck.TabIndex = 1;
            this.radioButtonTruck.TabStop = true;
            this.radioButtonTruck.Text = "Truck";
            this.radioButtonTruck.UseVisualStyleBackColor = true;
            this.radioButtonTruck.CheckedChanged += new System.EventHandler(this.radioButtonTruck_CheckedChanged);
            // 
            // radioButtonMotorcycle
            // 
            this.radioButtonMotorcycle.AutoSize = true;
            this.radioButtonMotorcycle.Location = new System.Drawing.Point(436, 12);
            this.radioButtonMotorcycle.Name = "radioButtonMotorcycle";
            this.radioButtonMotorcycle.Size = new System.Drawing.Size(132, 29);
            this.radioButtonMotorcycle.TabIndex = 2;
            this.radioButtonMotorcycle.TabStop = true;
            this.radioButtonMotorcycle.Text = "Motorcycle";
            this.radioButtonMotorcycle.UseVisualStyleBackColor = true;
            this.radioButtonMotorcycle.CheckedChanged += new System.EventHandler(this.radioButtonMotorcycle_CheckedChanged);
            // 
            // panelCar
            // 
            this.panelCar.Controls.Add(this.EnergyTypeCar);
            this.panelCar.Controls.Add(this.comboBoxCarColor);
            this.panelCar.Controls.Add(this.label2);
            this.panelCar.Location = new System.Drawing.Point(0, 99);
            this.panelCar.Name = "panelCar";
            this.panelCar.Size = new System.Drawing.Size(452, 162);
            this.panelCar.TabIndex = 3;
            this.panelCar.Visible = false;
            // 
            // EnergyTypeCar
            // 
            this.EnergyTypeCar.Controls.Add(this.label3);
            this.EnergyTypeCar.Controls.Add(this.radioButtonElectricCar);
            this.EnergyTypeCar.Controls.Add(this.radioButtonFuelCar);
            this.EnergyTypeCar.Location = new System.Drawing.Point(13, 15);
            this.EnergyTypeCar.Name = "EnergyTypeCar";
            this.EnergyTypeCar.Size = new System.Drawing.Size(420, 47);
            this.EnergyTypeCar.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Energy type:";
            // 
            // radioButtonElectricCar
            // 
            this.radioButtonElectricCar.AutoSize = true;
            this.radioButtonElectricCar.Location = new System.Drawing.Point(254, 11);
            this.radioButtonElectricCar.Name = "radioButtonElectricCar";
            this.radioButtonElectricCar.Size = new System.Drawing.Size(100, 29);
            this.radioButtonElectricCar.TabIndex = 4;
            this.radioButtonElectricCar.Text = "Electric";
            this.radioButtonElectricCar.UseVisualStyleBackColor = true;
            this.radioButtonElectricCar.CheckedChanged += new System.EventHandler(this.radioButtonElectricCar_CheckedChanged);
            // 
            // radioButtonFuelCar
            // 
            this.radioButtonFuelCar.AutoSize = true;
            this.radioButtonFuelCar.Location = new System.Drawing.Point(148, 11);
            this.radioButtonFuelCar.Name = "radioButtonFuelCar";
            this.radioButtonFuelCar.Size = new System.Drawing.Size(75, 29);
            this.radioButtonFuelCar.TabIndex = 3;
            this.radioButtonFuelCar.Text = "Fuel";
            this.radioButtonFuelCar.UseVisualStyleBackColor = true;
            this.radioButtonFuelCar.CheckedChanged += new System.EventHandler(this.radioButtonFuelCar_CheckedChanged);
            // 
            // comboBoxCarColor
            // 
            this.comboBoxCarColor.FormattingEnabled = true;
            this.comboBoxCarColor.Location = new System.Drawing.Point(120, 90);
            this.comboBoxCarColor.Name = "comboBoxCarColor";
            this.comboBoxCarColor.Size = new System.Drawing.Size(121, 33);
            this.comboBoxCarColor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Color:";
            // 
            // panelMotorcycle
            // 
            this.panelMotorcycle.Controls.Add(this.panelEnergyTypeMotorcycle);
            this.panelMotorcycle.Controls.Add(this.comboBoxMotorcycleLicenseType);
            this.panelMotorcycle.Controls.Add(this.label13);
            this.panelMotorcycle.Location = new System.Drawing.Point(218, 96);
            this.panelMotorcycle.Name = "panelMotorcycle";
            this.panelMotorcycle.Size = new System.Drawing.Size(452, 162);
            this.panelMotorcycle.TabIndex = 4;
            this.panelMotorcycle.Visible = false;
            // 
            // panelEnergyTypeMotorcycle
            // 
            this.panelEnergyTypeMotorcycle.Controls.Add(this.label12);
            this.panelEnergyTypeMotorcycle.Controls.Add(this.radioButtonElectricMotorcycle);
            this.panelEnergyTypeMotorcycle.Controls.Add(this.radioButtonFuelMotorcycle);
            this.panelEnergyTypeMotorcycle.Location = new System.Drawing.Point(13, 15);
            this.panelEnergyTypeMotorcycle.Name = "panelEnergyTypeMotorcycle";
            this.panelEnergyTypeMotorcycle.Size = new System.Drawing.Size(420, 47);
            this.panelEnergyTypeMotorcycle.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 25);
            this.label12.TabIndex = 5;
            this.label12.Text = "Energy type:";
            // 
            // radioButtonElectricMotorcycle
            // 
            this.radioButtonElectricMotorcycle.AutoSize = true;
            this.radioButtonElectricMotorcycle.Location = new System.Drawing.Point(254, 11);
            this.radioButtonElectricMotorcycle.Name = "radioButtonElectricMotorcycle";
            this.radioButtonElectricMotorcycle.Size = new System.Drawing.Size(100, 29);
            this.radioButtonElectricMotorcycle.TabIndex = 4;
            this.radioButtonElectricMotorcycle.Text = "Electric";
            this.radioButtonElectricMotorcycle.UseVisualStyleBackColor = true;
            this.radioButtonElectricMotorcycle.CheckedChanged += new System.EventHandler(this.radioButtonElectricMotorcycle_CheckedChanged);
            // 
            // radioButtonFuelMotorcycle
            // 
            this.radioButtonFuelMotorcycle.AutoSize = true;
            this.radioButtonFuelMotorcycle.Location = new System.Drawing.Point(148, 11);
            this.radioButtonFuelMotorcycle.Name = "radioButtonFuelMotorcycle";
            this.radioButtonFuelMotorcycle.Size = new System.Drawing.Size(75, 29);
            this.radioButtonFuelMotorcycle.TabIndex = 3;
            this.radioButtonFuelMotorcycle.Text = "Fuel";
            this.radioButtonFuelMotorcycle.UseVisualStyleBackColor = true;
            this.radioButtonFuelMotorcycle.CheckedChanged += new System.EventHandler(this.radioButtonFuelMotorcycle_CheckedChanged);
            // 
            // comboBoxMotorcycleLicenseType
            // 
            this.comboBoxMotorcycleLicenseType.FormattingEnabled = true;
            this.comboBoxMotorcycleLicenseType.Location = new System.Drawing.Point(161, 90);
            this.comboBoxMotorcycleLicenseType.Name = "comboBoxMotorcycleLicenseType";
            this.comboBoxMotorcycleLicenseType.Size = new System.Drawing.Size(121, 33);
            this.comboBoxMotorcycleLicenseType.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "License Type:";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Chartreuse;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addButton.Location = new System.Drawing.Point(599, 248);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(101, 44);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // VehicleOptionsPanel
            // 
            this.VehicleOptionsPanel.Controls.Add(this.label8);
            this.VehicleOptionsPanel.Controls.Add(this.radioButtonTruck);
            this.VehicleOptionsPanel.Controls.Add(this.radioButtonMotorcycle);
            this.VehicleOptionsPanel.Controls.Add(this.radioButtonCar);
            this.VehicleOptionsPanel.Location = new System.Drawing.Point(41, 26);
            this.VehicleOptionsPanel.Name = "VehicleOptionsPanel";
            this.VehicleOptionsPanel.Size = new System.Drawing.Size(601, 48);
            this.VehicleOptionsPanel.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(8, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Vehicle to insert:\r\n";
            // 
            // textBoxLicenseNumber
            // 
            this.textBoxLicenseNumber.Location = new System.Drawing.Point(184, 48);
            this.textBoxLicenseNumber.Name = "textBoxLicenseNumber";
            this.textBoxLicenseNumber.Size = new System.Drawing.Size(118, 30);
            this.textBoxLicenseNumber.TabIndex = 6;
            this.textBoxLicenseNumber.Leave += new System.EventHandler(this.textBoxLicenseNumber_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "License number:";
            // 
            // OwnerInfoPanel
            // 
            this.OwnerInfoPanel.Controls.Add(this.label6);
            this.OwnerInfoPanel.Controls.Add(this.textBoxOwnerPhoneNumber);
            this.OwnerInfoPanel.Controls.Add(this.label5);
            this.OwnerInfoPanel.Controls.Add(this.textBoxOwnerFullName);
            this.OwnerInfoPanel.Location = new System.Drawing.Point(29, 21);
            this.OwnerInfoPanel.Name = "OwnerInfoPanel";
            this.OwnerInfoPanel.Size = new System.Drawing.Size(720, 301);
            this.OwnerInfoPanel.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Phone number:";
            // 
            // textBoxOwnerPhoneNumber
            // 
            this.textBoxOwnerPhoneNumber.Location = new System.Drawing.Point(261, 179);
            this.textBoxOwnerPhoneNumber.Name = "textBoxOwnerPhoneNumber";
            this.textBoxOwnerPhoneNumber.Size = new System.Drawing.Size(286, 30);
            this.textBoxOwnerPhoneNumber.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Full name:";
            // 
            // textBoxOwnerFullName
            // 
            this.textBoxOwnerFullName.Location = new System.Drawing.Point(261, 122);
            this.textBoxOwnerFullName.Name = "textBoxOwnerFullName";
            this.textBoxOwnerFullName.Size = new System.Drawing.Size(283, 30);
            this.textBoxOwnerFullName.TabIndex = 9;
            // 
            // LicenseNumberPanel
            // 
            this.LicenseNumberPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LicenseNumberPanel.Controls.Add(this.comboBoxYear);
            this.LicenseNumberPanel.Controls.Add(this.label9);
            this.LicenseNumberPanel.Controls.Add(this.textBoxModelName);
            this.LicenseNumberPanel.Controls.Add(this.label7);
            this.LicenseNumberPanel.Controls.Add(this.InvalidLicenseNumberLabel);
            this.LicenseNumberPanel.Controls.Add(this.textBoxLicenseNumber);
            this.LicenseNumberPanel.Controls.Add(this.label4);
            this.LicenseNumberPanel.Location = new System.Drawing.Point(41, 20);
            this.LicenseNumberPanel.Name = "LicenseNumberPanel";
            this.LicenseNumberPanel.Size = new System.Drawing.Size(657, 280);
            this.LicenseNumberPanel.TabIndex = 8;
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Location = new System.Drawing.Point(184, 202);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(121, 33);
            this.comboBoxYear.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Year:";
            // 
            // textBoxModelName
            // 
            this.textBoxModelName.Location = new System.Drawing.Point(184, 129);
            this.textBoxModelName.Name = "textBoxModelName";
            this.textBoxModelName.Size = new System.Drawing.Size(118, 30);
            this.textBoxModelName.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Model name:";
            // 
            // InvalidLicenseNumberLabel
            // 
            this.InvalidLicenseNumberLabel.AutoSize = true;
            this.InvalidLicenseNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.InvalidLicenseNumberLabel.ForeColor = System.Drawing.Color.Red;
            this.InvalidLicenseNumberLabel.Location = new System.Drawing.Point(180, 83);
            this.InvalidLicenseNumberLabel.Name = "InvalidLicenseNumberLabel";
            this.InvalidLicenseNumberLabel.Size = new System.Drawing.Size(52, 20);
            this.InvalidLicenseNumberLabel.TabIndex = 7;
            this.InvalidLicenseNumberLabel.Text = "invalid";
            // 
            // AddVehicleTabControl
            // 
            this.AddVehicleTabControl.Controls.Add(this.OwnerInfoTabPage);
            this.AddVehicleTabControl.Controls.Add(this.VehicleInfoTabPage);
            this.AddVehicleTabControl.Controls.Add(this.tabPage1);
            this.AddVehicleTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AddVehicleTabControl.Location = new System.Drawing.Point(2, 47);
            this.AddVehicleTabControl.Name = "AddVehicleTabControl";
            this.AddVehicleTabControl.SelectedIndex = 0;
            this.AddVehicleTabControl.Size = new System.Drawing.Size(786, 366);
            this.AddVehicleTabControl.TabIndex = 9;
            this.AddVehicleTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.AddVehicleTabControl_Selected);
            // 
            // OwnerInfoTabPage
            // 
            this.OwnerInfoTabPage.Controls.Add(this.OwnerInfoPanel);
            this.OwnerInfoTabPage.Location = new System.Drawing.Point(4, 34);
            this.OwnerInfoTabPage.Name = "OwnerInfoTabPage";
            this.OwnerInfoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.OwnerInfoTabPage.Size = new System.Drawing.Size(778, 328);
            this.OwnerInfoTabPage.TabIndex = 0;
            this.OwnerInfoTabPage.Text = "Owner Information";
            this.OwnerInfoTabPage.UseVisualStyleBackColor = true;
            // 
            // VehicleInfoTabPage
            // 
            this.VehicleInfoTabPage.Controls.Add(this.LicenseNumberPanel);
            this.VehicleInfoTabPage.Location = new System.Drawing.Point(4, 34);
            this.VehicleInfoTabPage.Name = "VehicleInfoTabPage";
            this.VehicleInfoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.VehicleInfoTabPage.Size = new System.Drawing.Size(778, 328);
            this.VehicleInfoTabPage.TabIndex = 1;
            this.VehicleInfoTabPage.Text = "Vehicle Information";
            this.VehicleInfoTabPage.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelTruck);
            this.tabPage1.Controls.Add(this.panelMotorcycle);
            this.tabPage1.Controls.Add(this.panelBattery);
            this.tabPage1.Controls.Add(this.panelFuel);
            this.tabPage1.Controls.Add(this.panelCar);
            this.tabPage1.Controls.Add(this.addButton);
            this.tabPage1.Controls.Add(this.VehicleOptionsPanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(778, 328);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Choose Vehicle";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelTruck
            // 
            this.panelTruck.Controls.Add(this.numericUpDown1);
            this.panelTruck.Controls.Add(this.cargoVolumeLabel);
            this.panelTruck.Controls.Add(this.checkBoxDangerousSubstances);
            this.panelTruck.Controls.Add(this.panelEnergyTypeTruck);
            this.panelTruck.Location = new System.Drawing.Point(3, 80);
            this.panelTruck.Name = "panelTruck";
            this.panelTruck.Size = new System.Drawing.Size(451, 162);
            this.panelTruck.TabIndex = 5;
            this.panelTruck.Visible = false;
            // 
            // cargoVolumeLabel
            // 
            this.cargoVolumeLabel.AutoSize = true;
            this.cargoVolumeLabel.Location = new System.Drawing.Point(15, 118);
            this.cargoVolumeLabel.Name = "cargoVolumeLabel";
            this.cargoVolumeLabel.Size = new System.Drawing.Size(273, 25);
            this.cargoVolumeLabel.TabIndex = 4;
            this.cargoVolumeLabel.Text = "Cargo Volume (cubic meters):\r\n";
            // 
            // checkBoxDangerousSubstances
            // 
            this.checkBoxDangerousSubstances.AutoSize = true;
            this.checkBoxDangerousSubstances.Location = new System.Drawing.Point(15, 76);
            this.checkBoxDangerousSubstances.Name = "checkBoxDangerousSubstances";
            this.checkBoxDangerousSubstances.Size = new System.Drawing.Size(326, 29);
            this.checkBoxDangerousSubstances.TabIndex = 3;
            this.checkBoxDangerousSubstances.Text = "Contains Dangerous Substances";
            this.checkBoxDangerousSubstances.UseVisualStyleBackColor = true;
            // 
            // panelEnergyTypeTruck
            // 
            this.panelEnergyTypeTruck.Controls.Add(this.label14);
            this.panelEnergyTypeTruck.Controls.Add(this.radioButtonFuelTruck);
            this.panelEnergyTypeTruck.Location = new System.Drawing.Point(13, 15);
            this.panelEnergyTypeTruck.Name = "panelEnergyTypeTruck";
            this.panelEnergyTypeTruck.Size = new System.Drawing.Size(420, 47);
            this.panelEnergyTypeTruck.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 25);
            this.label14.TabIndex = 5;
            this.label14.Text = "Energy type:";
            // 
            // radioButtonFuelTruck
            // 
            this.radioButtonFuelTruck.AutoSize = true;
            this.radioButtonFuelTruck.Location = new System.Drawing.Point(148, 11);
            this.radioButtonFuelTruck.Name = "radioButtonFuelTruck";
            this.radioButtonFuelTruck.Size = new System.Drawing.Size(75, 29);
            this.radioButtonFuelTruck.TabIndex = 3;
            this.radioButtonFuelTruck.Text = "Fuel";
            this.radioButtonFuelTruck.UseVisualStyleBackColor = true;
            this.radioButtonFuelTruck.CheckedChanged += new System.EventHandler(this.radioButtonFuelTruck_CheckedChanged);
            // 
            // panelBattery
            // 
            this.panelBattery.Controls.Add(this.numericUpDownBatteryLevel);
            this.panelBattery.Controls.Add(this.label11);
            this.panelBattery.Location = new System.Drawing.Point(477, 109);
            this.panelBattery.Name = "panelBattery";
            this.panelBattery.Size = new System.Drawing.Size(275, 78);
            this.panelBattery.TabIndex = 7;
            this.panelBattery.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.Location = new System.Drawing.Point(4, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(264, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Current Battery Charge Level (kWh):";
            // 
            // panelFuel
            // 
            this.panelFuel.Controls.Add(this.numericUpDownFuelLevel);
            this.panelFuel.Controls.Add(this.label10);
            this.panelFuel.Location = new System.Drawing.Point(477, 115);
            this.panelFuel.Name = "panelFuel";
            this.panelFuel.Size = new System.Drawing.Size(223, 78);
            this.panelFuel.TabIndex = 6;
            this.panelFuel.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.Location = new System.Drawing.Point(11, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(191, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Current Fuel Level (Liters)";
            // 
            // buttonBackward
            // 
            this.buttonBackward.Location = new System.Drawing.Point(6, 415);
            this.buttonBackward.Name = "buttonBackward";
            this.buttonBackward.Size = new System.Drawing.Size(109, 40);
            this.buttonBackward.TabIndex = 12;
            this.buttonBackward.Text = "Backward";
            this.buttonBackward.UseVisualStyleBackColor = true;
            this.buttonBackward.Click += new System.EventHandler(this.buttonBackward_Click);
            // 
            // buttonForward
            // 
            this.buttonForward.Location = new System.Drawing.Point(686, 415);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(95, 40);
            this.buttonForward.TabIndex = 13;
            this.buttonForward.Text = "Forward";
            this.buttonForward.UseVisualStyleBackColor = true;
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // numericUpDownFuelLevel
            // 
            this.numericUpDownFuelLevel.DecimalPlaces = 1;
            this.numericUpDownFuelLevel.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownFuelLevel.Location = new System.Drawing.Point(17, 41);
            this.numericUpDownFuelLevel.Name = "numericUpDownFuelLevel";
            this.numericUpDownFuelLevel.Size = new System.Drawing.Size(120, 30);
            this.numericUpDownFuelLevel.TabIndex = 8;
            // 
            // numericUpDownBatteryLevel
            // 
            this.numericUpDownBatteryLevel.DecimalPlaces = 1;
            this.numericUpDownBatteryLevel.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownBatteryLevel.Location = new System.Drawing.Point(8, 41);
            this.numericUpDownBatteryLevel.Name = "numericUpDownBatteryLevel";
            this.numericUpDownBatteryLevel.Size = new System.Drawing.Size(120, 30);
            this.numericUpDownBatteryLevel.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(313, 118);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 30);
            this.numericUpDown1.TabIndex = 10;
            // 
            // AddVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonForward);
            this.Controls.Add(this.AddVehicleTabControl);
            this.Controls.Add(this.buttonBackward);
            this.Controls.Add(this.label1);
            this.Name = "AddVehicleForm";
            this.Text = "AddVehicleForm";
            this.Load += new System.EventHandler(this.AddVehicleForm_Load);
            this.panelCar.ResumeLayout(false);
            this.panelCar.PerformLayout();
            this.EnergyTypeCar.ResumeLayout(false);
            this.EnergyTypeCar.PerformLayout();
            this.panelMotorcycle.ResumeLayout(false);
            this.panelMotorcycle.PerformLayout();
            this.panelEnergyTypeMotorcycle.ResumeLayout(false);
            this.panelEnergyTypeMotorcycle.PerformLayout();
            this.VehicleOptionsPanel.ResumeLayout(false);
            this.VehicleOptionsPanel.PerformLayout();
            this.OwnerInfoPanel.ResumeLayout(false);
            this.OwnerInfoPanel.PerformLayout();
            this.LicenseNumberPanel.ResumeLayout(false);
            this.LicenseNumberPanel.PerformLayout();
            this.AddVehicleTabControl.ResumeLayout(false);
            this.OwnerInfoTabPage.ResumeLayout(false);
            this.VehicleInfoTabPage.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelTruck.ResumeLayout(false);
            this.panelTruck.PerformLayout();
            this.panelEnergyTypeTruck.ResumeLayout(false);
            this.panelEnergyTypeTruck.PerformLayout();
            this.panelBattery.ResumeLayout(false);
            this.panelBattery.PerformLayout();
            this.panelFuel.ResumeLayout(false);
            this.panelFuel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFuelLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBatteryLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonCar;
        private System.Windows.Forms.RadioButton radioButtonMotorcycle;
        private System.Windows.Forms.RadioButton radioButtonTruck;
        private System.Windows.Forms.Panel panelCar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox comboBoxCarColor;
        private System.Windows.Forms.Panel EnergyTypeCar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonElectricCar;
        private System.Windows.Forms.RadioButton radioButtonFuelCar;
        private System.Windows.Forms.Panel VehicleOptionsPanel;
        private System.Windows.Forms.TextBox textBoxLicenseNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel OwnerInfoPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxOwnerFullName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxOwnerPhoneNumber;
        private System.Windows.Forms.Panel LicenseNumberPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label InvalidLicenseNumberLabel;
        private System.Windows.Forms.TabControl AddVehicleTabControl;
        private System.Windows.Forms.TabPage OwnerInfoTabPage;
        private System.Windows.Forms.TabPage VehicleInfoTabPage;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxModelName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonBackward;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.Panel panelFuel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelBattery;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panelMotorcycle;
        private System.Windows.Forms.Panel panelEnergyTypeMotorcycle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton radioButtonElectricMotorcycle;
        private System.Windows.Forms.RadioButton radioButtonFuelMotorcycle;
        private System.Windows.Forms.ComboBox comboBoxMotorcycleLicenseType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panelTruck;
        private System.Windows.Forms.Panel panelEnergyTypeTruck;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton radioButtonFuelTruck;
        private System.Windows.Forms.Label cargoVolumeLabel;
        private System.Windows.Forms.CheckBox checkBoxDangerousSubstances;
        private System.Windows.Forms.NumericUpDown numericUpDownBatteryLevel;
        private System.Windows.Forms.NumericUpDown numericUpDownFuelLevel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}