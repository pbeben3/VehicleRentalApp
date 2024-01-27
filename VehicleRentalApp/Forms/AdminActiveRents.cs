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
    public partial class AdminActiveRents : Form
    {
        public AdminActiveRents()
        {
            InitializeComponent();
        }

        private void AdminActiveRents_Load(object sender, EventArgs e)
        {
            dataActiveRents.DataSource = Rents.GetActiveRentsData();
        }

        private void labelMenu_Click(object sender, EventArgs e)
        {
            AdminMenu formAdminMenu = new AdminMenu();
            formAdminMenu.Show();
            this.Close();
        }

        private void btnFinishRent_Click(object sender, EventArgs e)
        {
            Rents rent = Rents.MapDataToObject(Convert.ToInt32(txtRentID.Text));
            rent.FinishRent(rent);
            dataActiveRents.DataSource = Rents.GetActiveRentsData();
            MessageBox.Show("Wypożyczenie zakończone");
        }
    }
}
