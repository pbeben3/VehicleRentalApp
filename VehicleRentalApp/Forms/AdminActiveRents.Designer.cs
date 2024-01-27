namespace VehicleRentalApp.Forms
{
    partial class AdminActiveRents
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
            dataActiveRents = new DataGridView();
            label11 = new Label();
            label12 = new Label();
            txtRentID = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            btnFinishRent = new Button();
            labelMenu = new Label();
            ((System.ComponentModel.ISupportInitialize)dataActiveRents).BeginInit();
            SuspendLayout();
            // 
            // dataActiveRents
            // 
            dataActiveRents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataActiveRents.Location = new Point(25, 68);
            dataActiveRents.Name = "dataActiveRents";
            dataActiveRents.RowTemplate.Height = 25;
            dataActiveRents.Size = new Size(1053, 340);
            dataActiveRents.TabIndex = 45;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(437, 9);
            label11.Name = "label11";
            label11.Size = new Size(246, 30);
            label11.TabIndex = 46;
            label11.Text = "Aktywne Wypożyczenia";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(442, 429);
            label12.Name = "label12";
            label12.Size = new Size(241, 30);
            label12.TabIndex = 56;
            label12.Text = "Zakończ Wypożyczenie";
            // 
            // txtRentID
            // 
            txtRentID.BackColor = Color.PeachPuff;
            txtRentID.BorderStyle = BorderStyle.None;
            txtRentID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRentID.Location = new Point(487, 473);
            txtRentID.Multiline = true;
            txtRentID.Name = "txtRentID";
            txtRentID.Size = new Size(68, 24);
            txtRentID.TabIndex = 62;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(447, 471);
            label2.Name = "label2";
            label2.Size = new Size(34, 25);
            label2.TabIndex = 61;
            label2.Text = "ID:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(447, 499);
            panel1.Name = "panel1";
            panel1.Size = new Size(160, 1);
            panel1.TabIndex = 60;
            // 
            // btnFinishRent
            // 
            btnFinishRent.BackColor = Color.PeachPuff;
            btnFinishRent.FlatStyle = FlatStyle.Flat;
            btnFinishRent.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFinishRent.ForeColor = SystemColors.ControlText;
            btnFinishRent.Location = new Point(472, 517);
            btnFinishRent.Name = "btnFinishRent";
            btnFinishRent.Size = new Size(173, 40);
            btnFinishRent.TabIndex = 63;
            btnFinishRent.Text = "Zakończ";
            btnFinishRent.UseVisualStyleBackColor = false;
            btnFinishRent.Click += btnFinishRent_Click;
            // 
            // labelMenu
            // 
            labelMenu.AutoSize = true;
            labelMenu.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelMenu.Location = new Point(12, 601);
            labelMenu.Name = "labelMenu";
            labelMenu.Size = new Size(41, 17);
            labelMenu.TabIndex = 64;
            labelMenu.Text = "Menu";
            labelMenu.Click += labelMenu_Click;
            // 
            // AdminActiveRents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1105, 627);
            Controls.Add(labelMenu);
            Controls.Add(btnFinishRent);
            Controls.Add(txtRentID);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(dataActiveRents);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminActiveRents";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminActiveRents";
            Load += AdminActiveRents_Load;
            ((System.ComponentModel.ISupportInitialize)dataActiveRents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataActiveRents;
        private Label label11;
        private Label label12;
        private TextBox txtRentID;
        private Label label2;
        private Panel panel1;
        private Button btnFinishRent;
        private Label labelMenu;
    }
}