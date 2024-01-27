using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleRentalApp
{
    public partial class UserMenu : Form
    {
        private int CurrentLoggedUserID { get; set; }
        public UserMenu(int currentLoggedUserID)
        {
            InitializeComponent();
            CurrentLoggedUserID = currentLoggedUserID;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCars_Click(object sender, EventArgs e)
        {
            UserCars userCars = new UserCars(CurrentLoggedUserID);
            userCars.Show();
            this.Hide();
        }

        private void btnMotorcycles_Click(object sender, EventArgs e)
        {
            UserMotorcycles userMotorcycles = new UserMotorcycles(CurrentLoggedUserID);
            userMotorcycles.Show();
            this.Hide();
        }

        private void btnMyRents_Click(object sender, EventArgs e)
        {
            Forms.UserRents userRents = new Forms.UserRents(CurrentLoggedUserID);
            userRents.Show();
            this.Hide();
        }
    }
}
