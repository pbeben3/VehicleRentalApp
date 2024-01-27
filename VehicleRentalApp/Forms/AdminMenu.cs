using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VehicleRentalApp
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            AdminUsers formAdminUsers = new AdminUsers();
            formAdminUsers.Show();
            this.Hide();
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            AdminVehicles formAdminVehicles = new AdminVehicles();
            formAdminVehicles.Show();
            this.Hide();
        }

        private void btnRents_Click(object sender, EventArgs e)
        {
            Forms.AdminActiveRents formActiveRents = new Forms.AdminActiveRents();
            formActiveRents.Show();
            this.Hide();
        }

        private void btnFinishedRents_Click(object sender, EventArgs e)
        {
            Forms.AdminFinishedRents adminFinishedRents = new Forms.AdminFinishedRents();
            adminFinishedRents.Show();
            this.Hide();
        }
    }
}
