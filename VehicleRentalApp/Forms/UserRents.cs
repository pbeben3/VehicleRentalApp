using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleRentalApp.Classes;

namespace VehicleRentalApp.Forms
{
    public partial class UserRents : Form
    {
        private int CurrentLoggedUserID { get; set; }
        public UserRents(int currentLoggedUserID)
        {
            InitializeComponent();
            CurrentLoggedUserID = currentLoggedUserID;
        }

        private void UserRents_Load(object sender, EventArgs e)
        {
            dataUserRents.DataSource = Rents.GetUserRentsData(CurrentLoggedUserID);
        }

        private void labelMenu_Click(object sender, EventArgs e)
        {
            UserMenu userMenu = new UserMenu(CurrentLoggedUserID);
            userMenu.Show();
            this.Close();
        }
    }
}
