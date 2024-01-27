namespace VehicleRentalApp
{
    partial class UserMenu
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
            btnCars = new Button();
            btnMotorcycles = new Button();
            btnMyRents = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btnCars
            // 
            btnCars.BackColor = Color.PeachPuff;
            btnCars.FlatStyle = FlatStyle.Flat;
            btnCars.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCars.ForeColor = SystemColors.ControlText;
            btnCars.Location = new Point(28, 70);
            btnCars.Name = "btnCars";
            btnCars.Size = new Size(237, 40);
            btnCars.TabIndex = 14;
            btnCars.Text = "Samochody";
            btnCars.UseVisualStyleBackColor = false;
            btnCars.Click += btnCars_Click;
            // 
            // btnMotorcycles
            // 
            btnMotorcycles.BackColor = Color.PeachPuff;
            btnMotorcycles.FlatStyle = FlatStyle.Flat;
            btnMotorcycles.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnMotorcycles.ForeColor = SystemColors.ControlText;
            btnMotorcycles.Location = new Point(28, 127);
            btnMotorcycles.Name = "btnMotorcycles";
            btnMotorcycles.Size = new Size(237, 40);
            btnMotorcycles.TabIndex = 15;
            btnMotorcycles.Text = "Motocykle";
            btnMotorcycles.UseVisualStyleBackColor = false;
            btnMotorcycles.Click += btnMotorcycles_Click;
            // 
            // btnMyRents
            // 
            btnMyRents.BackColor = Color.PeachPuff;
            btnMyRents.FlatStyle = FlatStyle.Flat;
            btnMyRents.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnMyRents.ForeColor = SystemColors.ControlText;
            btnMyRents.Location = new Point(28, 183);
            btnMyRents.Name = "btnMyRents";
            btnMyRents.Size = new Size(237, 40);
            btnMyRents.TabIndex = 16;
            btnMyRents.Text = "Moje Wypożyczenia";
            btnMyRents.UseVisualStyleBackColor = false;
            btnMyRents.Click += btnMyRents_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(118, 259);
            label3.Name = "label3";
            label3.Size = new Size(43, 17);
            label3.TabIndex = 17;
            label3.Text = "Wyjdź";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.PeachPuff;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(19, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(261, 36);
            textBox1.TabIndex = 18;
            textBox1.Text = "Panel Użytkownika";
            // 
            // UserMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(292, 285);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(btnMyRents);
            Controls.Add(btnMotorcycles);
            Controls.Add(btnCars);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCars;
        private Button btnMotorcycles;
        private Button btnMyRents;
        private Label label3;
        private TextBox textBox1;
    }
}