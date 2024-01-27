namespace VehicleRentalApp.Forms
{
    partial class AdminFinishedRents
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
            labelMenu = new Label();
            label11 = new Label();
            dataFinishedRents = new DataGridView();
            btnPrintRent = new Button();
            txtRentID = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataFinishedRents).BeginInit();
            SuspendLayout();
            // 
            // labelMenu
            // 
            labelMenu.AutoSize = true;
            labelMenu.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelMenu.Location = new Point(12, 562);
            labelMenu.Name = "labelMenu";
            labelMenu.Size = new Size(41, 17);
            labelMenu.TabIndex = 65;
            labelMenu.Text = "Menu";
            labelMenu.Click += labelMenu_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(407, 9);
            label11.Name = "label11";
            label11.Size = new Size(278, 30);
            label11.TabIndex = 66;
            label11.Text = "Zakończone Wypożyczenia";
            // 
            // dataFinishedRents
            // 
            dataFinishedRents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataFinishedRents.Location = new Point(12, 57);
            dataFinishedRents.Name = "dataFinishedRents";
            dataFinishedRents.RowTemplate.Height = 25;
            dataFinishedRents.Size = new Size(1053, 340);
            dataFinishedRents.TabIndex = 67;
            // 
            // btnPrintRent
            // 
            btnPrintRent.BackColor = Color.PeachPuff;
            btnPrintRent.FlatStyle = FlatStyle.Flat;
            btnPrintRent.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrintRent.ForeColor = SystemColors.ControlText;
            btnPrintRent.Location = new Point(430, 495);
            btnPrintRent.Name = "btnPrintRent";
            btnPrintRent.Size = new Size(173, 40);
            btnPrintRent.TabIndex = 72;
            btnPrintRent.Text = "Drukuj";
            btnPrintRent.UseVisualStyleBackColor = false;
            btnPrintRent.Click += btnPrintRent_Click;
            // 
            // txtRentID
            // 
            txtRentID.BackColor = Color.PeachPuff;
            txtRentID.BorderStyle = BorderStyle.None;
            txtRentID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRentID.Location = new Point(470, 452);
            txtRentID.Multiline = true;
            txtRentID.Name = "txtRentID";
            txtRentID.Size = new Size(68, 24);
            txtRentID.TabIndex = 71;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(430, 450);
            label2.Name = "label2";
            label2.Size = new Size(34, 25);
            label2.TabIndex = 70;
            label2.Text = "ID:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(430, 478);
            panel1.Name = "panel1";
            panel1.Size = new Size(160, 1);
            panel1.TabIndex = 69;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(430, 420);
            label12.Name = "label12";
            label12.Size = new Size(167, 30);
            label12.TabIndex = 68;
            label12.Text = "Drukuj Paragon";
            // 
            // AdminFinishedRents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1078, 588);
            Controls.Add(btnPrintRent);
            Controls.Add(txtRentID);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label12);
            Controls.Add(dataFinishedRents);
            Controls.Add(label11);
            Controls.Add(labelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminFinishedRents";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminFinishedRents";
            Load += AdminFinishedRents_Load;
            ((System.ComponentModel.ISupportInitialize)dataFinishedRents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMenu;
        private Label label11;
        private DataGridView dataFinishedRents;
        private Button btnPrintRent;
        private TextBox txtRentID;
        private Label label2;
        private Panel panel1;
        private Label label12;
    }
}