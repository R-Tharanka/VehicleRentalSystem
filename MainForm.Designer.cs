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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 62);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 0;
            label1.Text = "Available Vehicles";
            // 
            // listBoxVehicles
            // 
            listBoxVehicles.FormattingEnabled = true;
            listBoxVehicles.Location = new Point(95, 130);
            listBoxVehicles.Name = "listBoxVehicles";
            listBoxVehicles.Size = new Size(300, 184);
            listBoxVehicles.TabIndex = 1;
            // 
            // btnLoadVehicles
            // 
            btnLoadVehicles.Location = new Point(269, 355);
            btnLoadVehicles.Name = "btnLoadVehicles";
            btnLoadVehicles.Size = new Size(126, 29);
            btnLoadVehicles.TabIndex = 2;
            btnLoadVehicles.Text = "Load Vehicles";
            btnLoadVehicles.UseVisualStyleBackColor = true;
            btnLoadVehicles.Click += btnLoadVehicles_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
