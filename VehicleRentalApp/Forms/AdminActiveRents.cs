using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using VehicleRentalApp.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            if (validateFinishedRent() == true)
            {
                Rents rent = Rents.MapDataToObject(Convert.ToInt32(txtRentID.Text));
                rent.FinishRent(rent);
                dataActiveRents.DataSource = Rents.GetActiveRentsData();
                MessageBox.Show("Wypożyczenie zakończone");
            }
            else
            {
                MessageBox.Show("ID niepoprawne");
            }
        }

        private bool validateFinishedRent()
        {
            bool validationPositive = true;
            if (string.IsNullOrWhiteSpace(txtRentID.Text))
            {
                validationPositive = false;
                ErrorProvider errorProvider1 = new ErrorProvider();
                errorProvider1.SetError(txtRentID, "Pole id nie może być puste");
            }
            else if (!int.TryParse(txtRentID.Text, out _))
            {
                validationPositive = false;
                ErrorProvider errorProvider2 = new ErrorProvider();
                errorProvider2.SetError(txtRentID, "Pole musi być liczbą ");
            }
            return validationPositive;
        }
    }
}
