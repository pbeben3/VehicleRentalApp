namespace VehicleRentalApp
{
    partial class AdminVehicles
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
            label1 = new Label();
            dataMotorcycles = new DataGridView();
            dataCars = new DataGridView();
            btnAddCar = new Button();
            btnAddMotorcycle = new Button();
            labelMenu = new Label();
            txtDeleteCar = new TextBox();
            label10 = new Label();
            panel10 = new Panel();
            label12 = new Label();
            label3 = new Label();
            txtDeleteMotorcycle = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            btnDeleteCar = new Button();
            btnDeleteMotorcycle = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataMotorcycles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataCars).BeginInit();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(691, 41);
            label11.Name = "label11";
            label11.Size = new Size(128, 30);
            label11.TabIndex = 40;
            label11.Text = "Samochody";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(691, 334);
            label1.Name = "label1";
            label1.Size = new Size(117, 30);
            label1.TabIndex = 42;
            label1.Text = "Motocykle";
            // 
            // dataMotorcycles
            // 
            dataMotorcycles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataMotorcycles.Location = new Point(191, 367);
            dataMotorcycles.Name = "dataMotorcycles";
            dataMotorcycles.RowTemplate.Height = 25;
            dataMotorcycles.Size = new Size(1200, 245);
            dataMotorcycles.TabIndex = 43;
            // 
            // dataCars
            // 
            dataCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataCars.Location = new Point(191, 74);
            dataCars.Name = "dataCars";
            dataCars.RowTemplate.Height = 25;
            dataCars.Size = new Size(1200, 245);
            dataCars.TabIndex = 44;
            // 
            // btnAddCar
            // 
            btnAddCar.BackColor = Color.PeachPuff;
            btnAddCar.FlatStyle = FlatStyle.Flat;
            btnAddCar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddCar.ForeColor = SystemColors.ControlText;
            btnAddCar.Location = new Point(12, 74);
            btnAddCar.Name = "btnAddCar";
            btnAddCar.Size = new Size(173, 40);
            btnAddCar.TabIndex = 45;
            btnAddCar.Text = "Dodaj Samochód";
            btnAddCar.UseVisualStyleBackColor = false;
            btnAddCar.Click += btnAddCar_Click;
            // 
            // btnAddMotorcycle
            // 
            btnAddMotorcycle.BackColor = Color.PeachPuff;
            btnAddMotorcycle.FlatStyle = FlatStyle.Flat;
            btnAddMotorcycle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddMotorcycle.ForeColor = SystemColors.ControlText;
            btnAddMotorcycle.Location = new Point(12, 367);
            btnAddMotorcycle.Name = "btnAddMotorcycle";
            btnAddMotorcycle.Size = new Size(173, 40);
            btnAddMotorcycle.TabIndex = 46;
            btnAddMotorcycle.Text = "Dodaj Motocykl";
            btnAddMotorcycle.UseVisualStyleBackColor = false;
            btnAddMotorcycle.Click += btnAddMotorcycle_Click;
            // 
            // labelMenu
            // 
            labelMenu.AutoSize = true;
            labelMenu.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelMenu.Location = new Point(12, 640);
            labelMenu.Name = "labelMenu";
            labelMenu.Size = new Size(41, 17);
            labelMenu.TabIndex = 48;
            labelMenu.Text = "Menu";
            labelMenu.Click += labelMenu_Click;
            // 
            // txtDeleteCar
            // 
            txtDeleteCar.BackColor = Color.PeachPuff;
            txtDeleteCar.BorderStyle = BorderStyle.None;
            txtDeleteCar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDeleteCar.Location = new Point(37, 196);
            txtDeleteCar.Multiline = true;
            txtDeleteCar.Name = "txtDeleteCar";
            txtDeleteCar.Size = new Size(83, 24);
            txtDeleteCar.TabIndex = 51;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(12, 194);
            label10.Name = "label10";
            label10.Size = new Size(30, 25);
            label10.TabIndex = 50;
            label10.Text = "ID";
            // 
            // panel10
            // 
            panel10.BackColor = Color.Black;
            panel10.Location = new Point(12, 222);
            panel10.Name = "panel10";
            panel10.Size = new Size(160, 1);
            panel10.TabIndex = 49;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(12, 155);
            label12.Name = "label12";
            label12.Size = new Size(173, 30);
            label12.TabIndex = 55;
            label12.Text = "Usuń Samochód";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 442);
            label3.Name = "label3";
            label3.Size = new Size(162, 30);
            label3.TabIndex = 56;
            label3.Text = "Usuń Motocykl";
            // 
            // txtDeleteMotorcycle
            // 
            txtDeleteMotorcycle.BackColor = Color.PeachPuff;
            txtDeleteMotorcycle.BorderStyle = BorderStyle.None;
            txtDeleteMotorcycle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDeleteMotorcycle.Location = new Point(37, 487);
            txtDeleteMotorcycle.Multiline = true;
            txtDeleteMotorcycle.Name = "txtDeleteMotorcycle";
            txtDeleteMotorcycle.Size = new Size(83, 24);
            txtDeleteMotorcycle.TabIndex = 59;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 485);
            label2.Name = "label2";
            label2.Size = new Size(30, 25);
            label2.TabIndex = 58;
            label2.Text = "ID";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(12, 513);
            panel1.Name = "panel1";
            panel1.Size = new Size(160, 1);
            panel1.TabIndex = 57;
            // 
            // btnDeleteCar
            // 
            btnDeleteCar.BackColor = Color.PeachPuff;
            btnDeleteCar.FlatStyle = FlatStyle.Flat;
            btnDeleteCar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteCar.ForeColor = SystemColors.ControlText;
            btnDeleteCar.Location = new Point(46, 229);
            btnDeleteCar.Name = "btnDeleteCar";
            btnDeleteCar.Size = new Size(83, 40);
            btnDeleteCar.TabIndex = 60;
            btnDeleteCar.Text = "Usuń";
            btnDeleteCar.UseVisualStyleBackColor = false;
            btnDeleteCar.Click += btnDeleteCar_Click;
            // 
            // btnDeleteMotorcycle
            // 
            btnDeleteMotorcycle.BackColor = Color.PeachPuff;
            btnDeleteMotorcycle.FlatStyle = FlatStyle.Flat;
            btnDeleteMotorcycle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteMotorcycle.ForeColor = SystemColors.ControlText;
            btnDeleteMotorcycle.Location = new Point(46, 520);
            btnDeleteMotorcycle.Name = "btnDeleteMotorcycle";
            btnDeleteMotorcycle.Size = new Size(83, 40);
            btnDeleteMotorcycle.TabIndex = 61;
            btnDeleteMotorcycle.Text = "Usuń";
            btnDeleteMotorcycle.UseVisualStyleBackColor = false;
            btnDeleteMotorcycle.Click += btnDeleteMotorcycle_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.PeachPuff;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.ForeColor = SystemColors.ControlText;
            btnRefresh.Location = new Point(691, 618);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(118, 40);
            btnRefresh.TabIndex = 62;
            btnRefresh.Text = "Odśwież";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // AdminVehicles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1403, 666);
            Controls.Add(btnRefresh);
            Controls.Add(btnDeleteMotorcycle);
            Controls.Add(btnDeleteCar);
            Controls.Add(txtDeleteMotorcycle);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label12);
            Controls.Add(txtDeleteCar);
            Controls.Add(label10);
            Controls.Add(panel10);
            Controls.Add(labelMenu);
            Controls.Add(btnAddMotorcycle);
            Controls.Add(btnAddCar);
            Controls.Add(dataCars);
            Controls.Add(dataMotorcycles);
            Controls.Add(label1);
            Controls.Add(label11);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminVehicles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminVehicles";
            Load += AdminUsers_Load;
            ((System.ComponentModel.ISupportInitialize)dataMotorcycles).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataCars).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label11;
        private Label label1;
        private DataGridView dataMotorcycles;
        private DataGridView dataCars;
        private Button btnAddCar;
        private Button btnAddMotorcycle;
        private Label labelMenu;
        private TextBox txtDeleteCar;
        private Label label10;
        private Panel panel10;
        private Label label12;
        private Label label3;
        private TextBox txtDeleteMotorcycle;
        private Label label2;
        private Panel panel1;
        private Button btnDeleteCar;
        private Button btnDeleteMotorcycle;
        private Button btnRefresh;
    }
}