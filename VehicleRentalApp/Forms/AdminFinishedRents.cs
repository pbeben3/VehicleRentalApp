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
using OfficeOpenXml;

namespace VehicleRentalApp.Forms
{
    public partial class AdminFinishedRents : Form
    {
        public AdminFinishedRents()
        {
            InitializeComponent();
        }

        private void labelMenu_Click(object sender, EventArgs e)
        {
            AdminMenu formAdminMenu = new AdminMenu();
            formAdminMenu.Show();
            this.Close();
        }

        private void AdminFinishedRents_Load(object sender, EventArgs e)
        {
            dataFinishedRents.DataSource = Rents.GetFinishedRentsData();
        }

        private void btnPrintRent_Click(object sender, EventArgs e)
        {
            if (validateReceipt() == true)
            {
                Rents rent = Rents.MapDataToObject(Convert.ToInt32(txtRentID.Text));
                rent.PrintReceipExcel(rent);
            }
            else
            {
                MessageBox.Show("ID niepoprawne");
            }
        }
        private bool validateReceipt()
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
