namespace VehicleRentalApp
{
    partial class AdminMenu
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
            btnUsers = new Button();
            btnVehicles = new Button();
            btnRents = new Button();
            btnFinishedRents = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.PeachPuff;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsers.ForeColor = SystemColors.ControlText;
            btnUsers.Location = new Point(28, 81);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(237, 40);
            btnUsers.TabIndex = 7;
            btnUsers.Text = "Użytkownicy";
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnVehicles
            // 
            btnVehicles.BackColor = Color.PeachPuff;
            btnVehicles.FlatStyle = FlatStyle.Flat;
            btnVehicles.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnVehicles.ForeColor = SystemColors.ControlText;
            btnVehicles.Location = new Point(28, 143);
            btnVehicles.Name = "btnVehicles";
            btnVehicles.Size = new Size(237, 40);
            btnVehicles.TabIndex = 8;
            btnVehicles.Text = "Pojazdy";
            btnVehicles.UseVisualStyleBackColor = false;
            btnVehicles.Click += btnVehicles_Click;
            // 
            // btnRents
            // 
            btnRents.BackColor = Color.PeachPuff;
            btnRents.FlatStyle = FlatStyle.Flat;
            btnRents.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRents.ForeColor = SystemColors.ControlText;
            btnRents.Location = new Point(28, 204);
            btnRents.Name = "btnRents";
            btnRents.Size = new Size(237, 40);
            btnRents.TabIndex = 9;
            btnRents.Text = "Wypożyczenia Aktywne";
            btnRents.UseVisualStyleBackColor = false;
            btnRents.Click += btnRents_Click;
            // 
            // btnFinishedRents
            // 
            btnFinishedRents.BackColor = Color.PeachPuff;
            btnFinishedRents.FlatStyle = FlatStyle.Flat;
            btnFinishedRents.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFinishedRents.ForeColor = SystemColors.ControlText;
            btnFinishedRents.Location = new Point(28, 265);
            btnFinishedRents.Name = "btnFinishedRents";
            btnFinishedRents.Size = new Size(237, 40);
            btnFinishedRents.TabIndex = 10;
            btnFinishedRents.Text = "Historia Wypożyczeń";
            btnFinishedRents.UseVisualStyleBackColor = false;
            btnFinishedRents.Click += btnFinishedRents_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(118, 349);
            label3.Name = "label3";
            label3.Size = new Size(43, 17);
            label3.TabIndex = 11;
            label3.Text = "Wyjdź";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.PeachPuff;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(272, 36);
            textBox1.TabIndex = 12;
            textBox1.Text = "Panel Administratora";
            // 
            // AdminMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(292, 447);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(btnFinishedRents);
            Controls.Add(btnRents);
            Controls.Add(btnVehicles);
            Controls.Add(btnUsers);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminMenu";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnUsers;
        private Button btnVehicles;
        private Button btnRents;
        private Button btnFinishedRents;
        private Label label3;
        private TextBox textBox1;
    }
}