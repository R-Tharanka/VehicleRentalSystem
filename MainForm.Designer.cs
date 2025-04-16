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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 33);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 0;
            label1.Text = "Available Vehicles";
            // 
            // listBoxVehicles
            // 
            listBoxVehicles.FormattingEnabled = true;
            listBoxVehicles.Location = new Point(95, 101);
            listBoxVehicles.Name = "listBoxVehicles";
            listBoxVehicles.Size = new Size(477, 224);
            listBoxVehicles.TabIndex = 1;
            // 
            // btnLoadVehicles
            // 
            btnLoadVehicles.Location = new Point(446, 367);
            btnLoadVehicles.Name = "btnLoadVehicles";
            btnLoadVehicles.Size = new Size(126, 29);
            btnLoadVehicles.TabIndex = 2;
            btnLoadVehicles.Text = "Load Vehicles";
            btnLoadVehicles.UseVisualStyleBackColor = true;
            btnLoadVehicles.Click += btnLoadVehicles_Click;
            // 
            // btnRent
            // 
            btnRent.Location = new Point(631, 101);
            btnRent.Name = "btnRent";
            btnRent.Size = new Size(113, 29);
            btnRent.TabIndex = 3;
            btnRent.Text = "Rent Vehicle";
            btnRent.UseVisualStyleBackColor = true;
            btnRent.Click += btnRent_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(631, 167);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(113, 29);
            btnReturn.TabIndex = 4;
            btnReturn.Text = "Return Vehicle";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReturn);
            Controls.Add(btnRent);
            Controls.Add(btnLoadVehicles);
            Controls.Add(listBoxVehicles);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBoxVehicles;
        private Button btnLoadVehicles;
        private Button btnRent;
        private Button btnReturn;
    }
}
