namespace VehicleRentalSystem
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            listBoxVehicles = new ListBox();
            btnLoadVehicles = new Button();
            btnRent = new Button();
            btnReturn = new Button();
            btnAddVehicle = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(58, 33);
            label1.Name = "label1";
            label1.Size = new Size(166, 28);
            label1.TabIndex = 0;
            label1.Text = "Available Vehicles";
            // 
            // listBoxVehicles
            // 
            listBoxVehicles.Font = new Font("Consolas", 9F);
            listBoxVehicles.FormattingEnabled = true;
            listBoxVehicles.ItemHeight = 18;
            listBoxVehicles.Location = new Point(58, 121);
            listBoxVehicles.Name = "listBoxVehicles";
            listBoxVehicles.Size = new Size(527, 202);
            listBoxVehicles.TabIndex = 1;
            // 
            // btnLoadVehicles
            // 
            btnLoadVehicles.Cursor = Cursors.Hand;
            btnLoadVehicles.Location = new Point(58, 362);
            btnLoadVehicles.Name = "btnLoadVehicles";
            btnLoadVehicles.Size = new Size(126, 29);
            btnLoadVehicles.TabIndex = 2;
            btnLoadVehicles.Text = "Load Vehicles";
            btnLoadVehicles.UseVisualStyleBackColor = true;
            btnLoadVehicles.Click += btnLoadVehicles_Click;
            // 
            // btnRent
            // 
            btnRent.Cursor = Cursors.Hand;
            btnRent.Location = new Point(269, 362);
            btnRent.Name = "btnRent";
            btnRent.Size = new Size(113, 29);
            btnRent.TabIndex = 3;
            btnRent.Text = "Rent Vehicle";
            btnRent.UseVisualStyleBackColor = true;
            btnRent.Click += btnRent_Click;
            // 
            // btnReturn
            // 
            btnReturn.Cursor = Cursors.Hand;
            btnReturn.Location = new Point(472, 362);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(113, 29);
            btnReturn.TabIndex = 4;
            btnReturn.Text = "Return Vehicle";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnAddVehicle
            // 
            btnAddVehicle.Cursor = Cursors.Hand;
            btnAddVehicle.Location = new Point(634, 121);
            btnAddVehicle.Name = "btnAddVehicle";
            btnAddVehicle.Size = new Size(124, 29);
            btnAddVehicle.TabIndex = 5;
            btnAddVehicle.Text = "Add Vehicle";
            btnAddVehicle.UseVisualStyleBackColor = true;
            btnAddVehicle.Click += btnAddVehicle_Click;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Location = new Point(634, 196);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(124, 29);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Remove Vehicle";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnAddVehicle);
            Controls.Add(btnReturn);
            Controls.Add(btnRent);
            Controls.Add(btnLoadVehicles);
            Controls.Add(listBoxVehicles);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Vehicle Rental System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBoxVehicles;
        private Button btnLoadVehicles;
        private Button btnRent;
        private Button btnReturn;
        private Button btnAddVehicle;
        private Button btnDelete;
    }
}
