namespace VehicleRentalApp
{
    partial class UserMotorcycles
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
            dataMotorcycles = new DataGridView();
            labelMenu = new Label();
            label12 = new Label();
            txtMotorcycleID = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            txtRentDate = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            txtReturnDate = new TextBox();
            label3 = new Label();
            panel3 = new Panel();
            btnBook = new Button();
            ((System.ComponentModel.ISupportInitialize)dataMotorcycles).BeginInit();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(474, 9);
            label11.Name = "label11";
            label11.Size = new Size(222, 30);
            label11.TabIndex = 41;
            label11.Text = " Dostępne Motocykle";
            // 
            // dataMotorcycles
            // 
            dataMotorcycles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataMotorcycles.Location = new Point(3, 58);
            dataMotorcycles.Name = "dataMotorcycles";
            dataMotorcycles.RowTemplate.Height = 25;
            dataMotorcycles.Size = new Size(1200, 245);
            dataMotorcycles.TabIndex = 44;
            // 
            // labelMenu
            // 
            labelMenu.AutoSize = true;
            labelMenu.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelMenu.Location = new Point(12, 520);
            labelMenu.Name = "labelMenu";
            labelMenu.Size = new Size(41, 17);
            labelMenu.TabIndex = 49;
            labelMenu.Text = "Menu";
            labelMenu.Click += labelMenu_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(485, 306);
            label12.Name = "label12";
            label12.Size = new Size(202, 30);
            label12.TabIndex = 56;
            label12.Text = "Rezerwuj Motocykl";
            // 
            // txtMotorcycleID
            // 
            txtMotorcycleID.BackColor = Color.PeachPuff;
            txtMotorcycleID.BorderStyle = BorderStyle.None;
            txtMotorcycleID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMotorcycleID.Location = new Point(553, 341);
            txtMotorcycleID.Multiline = true;
            txtMotorcycleID.Name = "txtMotorcycleID";
            txtMotorcycleID.Size = new Size(177, 24);
            txtMotorcycleID.TabIndex = 62;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(430, 340);
            label2.Name = "label2";
            label2.Size = new Size(126, 25);
            label2.TabIndex = 61;
            label2.Text = "ID Motocykla:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(430, 368);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 1);
            panel1.TabIndex = 60;
            // 
            // txtRentDate
            // 
            txtRentDate.BackColor = Color.PeachPuff;
            txtRentDate.BorderStyle = BorderStyle.None;
            txtRentDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRentDate.Location = new Point(605, 371);
            txtRentDate.Multiline = true;
            txtRentDate.Name = "txtRentDate";
            txtRentDate.Size = new Size(125, 24);
            txtRentDate.TabIndex = 65;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(430, 370);
            label1.Name = "label1";
            label1.Size = new Size(181, 25);
            label1.TabIndex = 64;
            label1.Text = "Data Wypożyczenia:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(430, 398);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 1);
            panel2.TabIndex = 63;
            // 
            // txtReturnDate
            // 
            txtReturnDate.BackColor = Color.PeachPuff;
            txtReturnDate.BorderStyle = BorderStyle.None;
            txtReturnDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtReturnDate.Location = new Point(544, 401);
            txtReturnDate.Multiline = true;
            txtReturnDate.Name = "txtReturnDate";
            txtReturnDate.Size = new Size(174, 24);
            txtReturnDate.TabIndex = 68;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(430, 400);
            label3.Name = "label3";
            label3.Size = new Size(120, 25);
            label3.TabIndex = 67;
            label3.Text = "Data Zwrotu:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(430, 428);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 1);
            panel3.TabIndex = 66;
            // 
            // btnBook
            // 
            btnBook.BackColor = Color.PeachPuff;
            btnBook.FlatStyle = FlatStyle.Flat;
            btnBook.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBook.ForeColor = SystemColors.ControlText;
            btnBook.Location = new Point(523, 435);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(118, 40);
            btnBook.TabIndex = 69;
            btnBook.Text = "Rezerwuj";
            btnBook.UseVisualStyleBackColor = false;
            // 
            // UserMotorcycles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1206, 546);
            Controls.Add(btnBook);
            Controls.Add(txtReturnDate);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(txtRentDate);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(txtMotorcycleID);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label12);
            Controls.Add(labelMenu);
            Controls.Add(dataMotorcycles);
            Controls.Add(label11);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserMotorcycles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserMotorcycles";
            Load += UserMotorcycles_Load;
            ((System.ComponentModel.ISupportInitialize)dataMotorcycles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label11;
        private DataGridView dataMotorcycles;
        private Label labelMenu;
        private Label label12;
        private TextBox txtMotorcycleID;
        private Label label2;
        private Panel panel1;
        private TextBox txtRentDate;
        private Label label1;
        private Panel panel2;
        private TextBox txtReturnDate;
        private Label label3;
        private Panel panel3;
        private Button btnBook;
    }
}