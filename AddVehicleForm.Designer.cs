namespace VehicleRentalSystem
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
            lblRegNumber = new Label();
            txtRegNumber = new TextBox();
            txtBrand = new TextBox();
            lblBrand = new Label();
            lblSidecar = new Label();
            lblYear = new Label();
            numYear = new NumericUpDown();
            lblType = new Label();
            comboType = new ComboBox();
            numDoors = new NumericUpDown();
            lblDoors = new Label();
            chkSidecar = new CheckBox();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)numYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDoors).BeginInit();
            SuspendLayout();
            // 
            // lblRegNumber
            // 
            lblRegNumber.AutoSize = true;
            lblRegNumber.Font = new Font("Segoe UI", 9F);
            lblRegNumber.Location = new Point(194, 80);
            lblRegNumber.Name = "lblRegNumber";
            lblRegNumber.Size = new Size(147, 20);
            lblRegNumber.TabIndex = 0;
            lblRegNumber.Text = "Registration Number";
            // 
            // txtRegNumber
            // 
            txtRegNumber.Font = new Font("Segoe UI", 9F);
            txtRegNumber.Location = new Point(401, 75);
            txtRegNumber.Name = "txtRegNumber";
            txtRegNumber.Size = new Size(184, 27);
            txtRegNumber.TabIndex = 1;
            // 
            // txtBrand
            // 
            txtBrand.Font = new Font("Segoe UI", 9F);
            txtBrand.Location = new Point(401, 124);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(184, 27);
            txtBrand.TabIndex = 3;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI", 9F);
            lblBrand.Location = new Point(194, 129);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(48, 20);
            lblBrand.TabIndex = 2;
            lblBrand.Text = "Brand";
            // 
            // lblSidecar
            // 
            lblSidecar.AutoSize = true;
            lblSidecar.Font = new Font("Segoe UI", 9F);
            lblSidecar.Location = new Point(194, 286);
            lblSidecar.Name = "lblSidecar";
            lblSidecar.Size = new Size(87, 20);
            lblSidecar.TabIndex = 4;
            lblSidecar.Text = "Has Sidecar";
            lblSidecar.Visible = false;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI", 9F);
            lblYear.Location = new Point(194, 179);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(37, 20);
            lblYear.TabIndex = 6;
            lblYear.Text = "Year";
            // 
            // numYear
            // 
            numYear.Font = new Font("Segoe UI", 9F);
            numYear.Location = new Point(401, 177);
            numYear.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            numYear.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            numYear.Name = "numYear";
            numYear.Size = new Size(184, 27);
            numYear.TabIndex = 7;
            numYear.Value = new decimal(new int[] { 2023, 0, 0, 0 });
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI", 9F);
            lblType.Location = new Point(194, 232);
            lblType.Name = "lblType";
            lblType.Size = new Size(91, 20);
            lblType.TabIndex = 8;
            lblType.Text = "Vehicle Type";
            // 
            // comboType
            // 
            comboType.Font = new Font("Segoe UI", 9F);
            comboType.FormattingEnabled = true;
            comboType.Items.AddRange(new object[] { "Car", "Motorbike" });
            comboType.Location = new Point(401, 226);
            comboType.Name = "comboType";
            comboType.Size = new Size(184, 28);
            comboType.TabIndex = 9;
            comboType.SelectedIndexChanged += comboType_SelectedIndexChanged;
            // 
            // numDoors
            // 
            numDoors.Font = new Font("Segoe UI", 9F);
            numDoors.Location = new Point(401, 279);
            numDoors.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            numDoors.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numDoors.Name = "numDoors";
            numDoors.Size = new Size(184, 27);
            numDoors.TabIndex = 11;
            numDoors.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // lblDoors
            // 
            lblDoors.AutoSize = true;
            lblDoors.Font = new Font("Segoe UI", 9F);
            lblDoors.Location = new Point(194, 284);
            lblDoors.Name = "lblDoors";
            lblDoors.Size = new Size(125, 20);
            lblDoors.TabIndex = 10;
            lblDoors.Text = "Number of Doors";
            lblDoors.Visible = false;
            // 
            // chkSidecar
            // 
            chkSidecar.AutoSize = true;
            chkSidecar.Font = new Font("Segoe UI", 9F);
            chkSidecar.Location = new Point(401, 283);
            chkSidecar.Name = "chkSidecar";
            chkSidecar.Size = new Size(52, 24);
            chkSidecar.TabIndex = 12;
            chkSidecar.Text = "Yes";
            chkSidecar.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Font = new Font("Segoe UI", 9F);
            btnAdd.Location = new Point(340, 351);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(101, 29);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add Vehicle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddVehicleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(chkSidecar);
            Controls.Add(numDoors);
            Controls.Add(lblDoors);
            Controls.Add(comboType);
            Controls.Add(lblType);
            Controls.Add(numYear);
            Controls.Add(lblYear);
            Controls.Add(lblSidecar);
            Controls.Add(txtBrand);
            Controls.Add(lblBrand);
            Controls.Add(txtRegNumber);
            Controls.Add(lblRegNumber);
            Name = "AddVehicleForm";
            Text = "Add New Vehicle";
            Load += AddVehicleForm_Load;
            ((System.ComponentModel.ISupportInitialize)numYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDoors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegNumber;
        private TextBox txtRegNumber;
        private TextBox txtBrand;
        private Label lblBrand;
        private Label lblSidecar;
        private Label lblYear;
        private NumericUpDown numYear;
        private Label lblType;
        private ComboBox comboType;
        private NumericUpDown numDoors;
        private Label lblDoors;
        private CheckBox chkSidecar;
        private Button btnAdd;
    }
}