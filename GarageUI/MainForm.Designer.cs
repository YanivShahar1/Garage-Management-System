
namespace GarageUI
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.AddVehicleButton = new System.Windows.Forms.Button();
            this.RemoveVehicleButton = new System.Windows.Forms.Button();
            this.ViewVehicleDetailsButton = new System.Windows.Forms.Button();
            this.ListAllVehiclesButton = new System.Windows.Forms.Button();
            this.SearchVehicleButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(110, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 72);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(135, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddVehicleButton
            // 
            this.AddVehicleButton.Location = new System.Drawing.Point(77, 163);
            this.AddVehicleButton.Name = "AddVehicleButton";
            this.AddVehicleButton.Size = new System.Drawing.Size(116, 96);
            this.AddVehicleButton.TabIndex = 1;
            this.AddVehicleButton.Text = "Add Vehicle";
            this.AddVehicleButton.UseVisualStyleBackColor = true;
            this.AddVehicleButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // RemoveVehicleButton
            // 
            this.RemoveVehicleButton.Location = new System.Drawing.Point(289, 163);
            this.RemoveVehicleButton.Name = "RemoveVehicleButton";
            this.RemoveVehicleButton.Size = new System.Drawing.Size(116, 96);
            this.RemoveVehicleButton.TabIndex = 2;
            this.RemoveVehicleButton.Text = "Remove Vehicle";
            this.RemoveVehicleButton.UseVisualStyleBackColor = true;
            // 
            // ViewVehicleDetailsButton
            // 
            this.ViewVehicleDetailsButton.Location = new System.Drawing.Point(510, 163);
            this.ViewVehicleDetailsButton.Name = "ViewVehicleDetailsButton";
            this.ViewVehicleDetailsButton.Size = new System.Drawing.Size(116, 96);
            this.ViewVehicleDetailsButton.TabIndex = 3;
            this.ViewVehicleDetailsButton.Text = "View Vehicle Details";
            this.ViewVehicleDetailsButton.UseVisualStyleBackColor = true;
            // 
            // ListAllVehiclesButton
            // 
            this.ListAllVehiclesButton.Location = new System.Drawing.Point(77, 298);
            this.ListAllVehiclesButton.Name = "ListAllVehiclesButton";
            this.ListAllVehiclesButton.Size = new System.Drawing.Size(116, 96);
            this.ListAllVehiclesButton.TabIndex = 4;
            this.ListAllVehiclesButton.Text = "List All Vehicles";
            this.ListAllVehiclesButton.UseVisualStyleBackColor = true;
            // 
            // SearchVehicleButton
            // 
            this.SearchVehicleButton.Location = new System.Drawing.Point(289, 298);
            this.SearchVehicleButton.Name = "SearchVehicleButton";
            this.SearchVehicleButton.Size = new System.Drawing.Size(116, 96);
            this.SearchVehicleButton.TabIndex = 5;
            this.SearchVehicleButton.Text = "Search for Vehicle";
            this.SearchVehicleButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchVehicleButton);
            this.Controls.Add(this.ListAllVehiclesButton);
            this.Controls.Add(this.ViewVehicleDetailsButton);
            this.Controls.Add(this.RemoveVehicleButton);
            this.Controls.Add(this.AddVehicleButton);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddVehicleButton;
        private System.Windows.Forms.Button RemoveVehicleButton;
        private System.Windows.Forms.Button ViewVehicleDetailsButton;
        private System.Windows.Forms.Button ListAllVehiclesButton;
        private System.Windows.Forms.Button SearchVehicleButton;
    }
}

