namespace VehicleRentalApp.Forms
{
    partial class UserRents
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
            label11 = new Label();
            dataUserRents = new DataGridView();
            labelMenu = new Label();
            ((System.ComponentModel.ISupportInitialize)dataUserRents).BeginInit();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(437, 9);
            label11.Name = "label11";
            label11.Size = new Size(209, 30);
            label11.TabIndex = 67;
            label11.Text = "Moje Wypożyczenia";
            // 
            // dataUserRents
            // 
            dataUserRents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataUserRents.Location = new Point(12, 64);
            dataUserRents.Name = "dataUserRents";
            dataUserRents.RowTemplate.Height = 25;
            dataUserRents.Size = new Size(1053, 340);
            dataUserRents.TabIndex = 68;
            // 
            // labelMenu
            // 
            labelMenu.AutoSize = true;
            labelMenu.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelMenu.Location = new Point(12, 416);
            labelMenu.Name = "labelMenu";
            labelMenu.Size = new Size(41, 17);
            labelMenu.TabIndex = 69;
            labelMenu.Text = "Menu";
            labelMenu.Click += labelMenu_Click;
            // 
            // UserRents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1078, 442);
            Controls.Add(labelMenu);
            Controls.Add(dataUserRents);
            Controls.Add(label11);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserRents";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserRents";
            Load += UserRents_Load;
            ((System.ComponentModel.ISupportInitialize)dataUserRents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label11;
        private DataGridView dataUserRents;
        private Label labelMenu;
    }
}