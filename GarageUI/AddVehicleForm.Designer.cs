
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
            this.CarPanel = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCarColor = new System.Windows.Forms.ComboBox();
            this.EnergyTypeCar = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxLicenseNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.OwnerInfoPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LicenseNumberPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.InvalidLicenseNumberLabel = new System.Windows.Forms.Label();
            this.AddVehicleTabPage = new System.Windows.Forms.TabControl();
            this.OwnerInfoTabPage = new System.Windows.Forms.TabPage();
            this.VehicleInfoTabPage = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.CarPanel.SuspendLayout();
            this.EnergyTypeCar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.OwnerInfoPanel.SuspendLayout();
            this.LicenseNumberPanel.SuspendLayout();
            this.AddVehicleTabPage.SuspendLayout();
            this.OwnerInfoTabPage.SuspendLayout();
            this.VehicleInfoTabPage.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.radioButtonCar.Location = new System.Drawing.Point(178, 21);
            this.radioButtonCar.Name = "radioButtonCar";
            this.radioButtonCar.Size = new System.Drawing.Size(59, 24);
            this.radioButtonCar.TabIndex = 0;
            this.radioButtonCar.TabStop = true;
            this.radioButtonCar.Text = "Car";
            this.radioButtonCar.UseVisualStyleBackColor = true;
            this.radioButtonCar.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonTruck
            // 
            this.radioButtonTruck.AutoSize = true;
            this.radioButtonTruck.Location = new System.Drawing.Point(291, 21);
            this.radioButtonTruck.Name = "radioButtonTruck";
            this.radioButtonTruck.Size = new System.Drawing.Size(73, 24);
            this.radioButtonTruck.TabIndex = 1;
            this.radioButtonTruck.TabStop = true;
            this.radioButtonTruck.Text = "Truck";
            this.radioButtonTruck.UseVisualStyleBackColor = true;
            this.radioButtonTruck.CheckedChanged += new System.EventHandler(this.radioButtonTruck_CheckedChanged);
            // 
            // radioButtonMotorcycle
            // 
            this.radioButtonMotorcycle.AutoSize = true;
            this.radioButtonMotorcycle.Location = new System.Drawing.Point(408, 21);
            this.radioButtonMotorcycle.Name = "radioButtonMotorcycle";
            this.radioButtonMotorcycle.Size = new System.Drawing.Size(110, 24);
            this.radioButtonMotorcycle.TabIndex = 2;
            this.radioButtonMotorcycle.TabStop = true;
            this.radioButtonMotorcycle.Text = "Motorcycle";
            this.radioButtonMotorcycle.UseVisualStyleBackColor = true;
            // 
            // CarPanel
            // 
            this.CarPanel.Controls.Add(this.EnergyTypeCar);
            this.CarPanel.Controls.Add(this.comboBoxCarColor);
            this.CarPanel.Controls.Add(this.label2);
            this.CarPanel.Location = new System.Drawing.Point(41, 100);
            this.CarPanel.Name = "CarPanel";
            this.CarPanel.Size = new System.Drawing.Size(525, 183);
            this.CarPanel.TabIndex = 3;
            this.CarPanel.Visible = false;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Color:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBoxCarColor
            // 
            this.comboBoxCarColor.FormattingEnabled = true;
            this.comboBoxCarColor.Location = new System.Drawing.Point(120, 93);
            this.comboBoxCarColor.Name = "comboBoxCarColor";
            this.comboBoxCarColor.Size = new System.Drawing.Size(121, 28);
            this.comboBoxCarColor.TabIndex = 1;
            // 
            // EnergyTypeCar
            // 
            this.EnergyTypeCar.Controls.Add(this.label3);
            this.EnergyTypeCar.Controls.Add(this.radioButton2);
            this.EnergyTypeCar.Controls.Add(this.radioButton1);
            this.EnergyTypeCar.Location = new System.Drawing.Point(18, 12);
            this.EnergyTypeCar.Name = "EnergyTypeCar";
            this.EnergyTypeCar.Size = new System.Drawing.Size(309, 59);
            this.EnergyTypeCar.TabIndex = 2;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(113, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(65, 24);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.Text = "Fuel";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(190, 23);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(86, 24);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "Electric";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Energy type:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.radioButtonTruck);
            this.panel1.Controls.Add(this.radioButtonMotorcycle);
            this.panel1.Controls.Add(this.radioButtonCar);
            this.panel1.Location = new System.Drawing.Point(41, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 61);
            this.panel1.TabIndex = 5;
            // 
            // textBoxLicenseNumber
            // 
            this.textBoxLicenseNumber.Location = new System.Drawing.Point(169, 48);
            this.textBoxLicenseNumber.Name = "textBoxLicenseNumber";
            this.textBoxLicenseNumber.Size = new System.Drawing.Size(118, 26);
            this.textBoxLicenseNumber.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "License number:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // OwnerInfoPanel
            // 
            this.OwnerInfoPanel.Controls.Add(this.label6);
            this.OwnerInfoPanel.Controls.Add(this.textBox2);
            this.OwnerInfoPanel.Controls.Add(this.label5);
            this.OwnerInfoPanel.Controls.Add(this.textBox1);
            this.OwnerInfoPanel.Location = new System.Drawing.Point(55, 31);
            this.OwnerInfoPanel.Name = "OwnerInfoPanel";
            this.OwnerInfoPanel.Size = new System.Drawing.Size(645, 256);
            this.OwnerInfoPanel.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Full name:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(273, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 26);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Phone number:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(270, 126);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 26);
            this.textBox2.TabIndex = 11;
            // 
            // LicenseNumberPanel
            // 
            this.LicenseNumberPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LicenseNumberPanel.Controls.Add(this.comboBoxYear);
            this.LicenseNumberPanel.Controls.Add(this.label9);
            this.LicenseNumberPanel.Controls.Add(this.textBoxModel);
            this.LicenseNumberPanel.Controls.Add(this.label7);
            this.LicenseNumberPanel.Controls.Add(this.InvalidLicenseNumberLabel);
            this.LicenseNumberPanel.Controls.Add(this.textBoxLicenseNumber);
            this.LicenseNumberPanel.Controls.Add(this.label4);
            this.LicenseNumberPanel.Location = new System.Drawing.Point(77, 20);
            this.LicenseNumberPanel.Name = "LicenseNumberPanel";
            this.LicenseNumberPanel.Size = new System.Drawing.Size(602, 298);
            this.LicenseNumberPanel.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(15, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Vehicle to insert:\r\n";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // InvalidLicenseNumberLabel
            // 
            this.InvalidLicenseNumberLabel.AutoSize = true;
            this.InvalidLicenseNumberLabel.ForeColor = System.Drawing.Color.Red;
            this.InvalidLicenseNumberLabel.Location = new System.Drawing.Point(177, 77);
            this.InvalidLicenseNumberLabel.Name = "InvalidLicenseNumberLabel";
            this.InvalidLicenseNumberLabel.Size = new System.Drawing.Size(52, 20);
            this.InvalidLicenseNumberLabel.TabIndex = 7;
            this.InvalidLicenseNumberLabel.Text = "invalid";
            // 
            // AddVehicleTabPage
            // 
            this.AddVehicleTabPage.Controls.Add(this.OwnerInfoTabPage);
            this.AddVehicleTabPage.Controls.Add(this.VehicleInfoTabPage);
            this.AddVehicleTabPage.Controls.Add(this.tabPage1);
            this.AddVehicleTabPage.Location = new System.Drawing.Point(2, 47);
            this.AddVehicleTabPage.Name = "AddVehicleTabPage";
            this.AddVehicleTabPage.SelectedIndex = 0;
            this.AddVehicleTabPage.Size = new System.Drawing.Size(786, 391);
            this.AddVehicleTabPage.TabIndex = 9;
            // 
            // OwnerInfoTabPage
            // 
            this.OwnerInfoTabPage.Controls.Add(this.OwnerInfoPanel);
            this.OwnerInfoTabPage.Location = new System.Drawing.Point(4, 29);
            this.OwnerInfoTabPage.Name = "OwnerInfoTabPage";
            this.OwnerInfoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.OwnerInfoTabPage.Size = new System.Drawing.Size(778, 358);
            this.OwnerInfoTabPage.TabIndex = 0;
            this.OwnerInfoTabPage.Text = "Owner Information";
            this.OwnerInfoTabPage.UseVisualStyleBackColor = true;
            // 
            // VehicleInfoTabPage
            // 
            this.VehicleInfoTabPage.Controls.Add(this.LicenseNumberPanel);
            this.VehicleInfoTabPage.Location = new System.Drawing.Point(4, 29);
            this.VehicleInfoTabPage.Name = "VehicleInfoTabPage";
            this.VehicleInfoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.VehicleInfoTabPage.Size = new System.Drawing.Size(778, 358);
            this.VehicleInfoTabPage.TabIndex = 1;
            this.VehicleInfoTabPage.Text = "Vehicle Information";
            this.VehicleInfoTabPage.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CarPanel);
            this.tabPage1.Controls.Add(this.addButton);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(778, 358);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Choose Vehicle";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(169, 129);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(118, 26);
            this.textBoxModel.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Model name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Year:";
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Location = new System.Drawing.Point(169, 202);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(121, 28);
            this.comboBoxYear.TabIndex = 11;
            // 
            // AddVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddVehicleTabPage);
            this.Controls.Add(this.label1);
            this.Name = "AddVehicleForm";
            this.Text = "AddVehicleForm";
            this.CarPanel.ResumeLayout(false);
            this.CarPanel.PerformLayout();
            this.EnergyTypeCar.ResumeLayout(false);
            this.EnergyTypeCar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.OwnerInfoPanel.ResumeLayout(false);
            this.OwnerInfoPanel.PerformLayout();
            this.LicenseNumberPanel.ResumeLayout(false);
            this.LicenseNumberPanel.PerformLayout();
            this.AddVehicleTabPage.ResumeLayout(false);
            this.OwnerInfoTabPage.ResumeLayout(false);
            this.VehicleInfoTabPage.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonCar;
        private System.Windows.Forms.RadioButton radioButtonMotorcycle;
        private System.Windows.Forms.RadioButton radioButtonTruck;
        private System.Windows.Forms.Panel CarPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox comboBoxCarColor;
        private System.Windows.Forms.Panel EnergyTypeCar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxLicenseNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel OwnerInfoPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel LicenseNumberPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label InvalidLicenseNumberLabel;
        private System.Windows.Forms.TabControl AddVehicleTabPage;
        private System.Windows.Forms.TabPage OwnerInfoTabPage;
        private System.Windows.Forms.TabPage VehicleInfoTabPage;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label label7;
    }
}