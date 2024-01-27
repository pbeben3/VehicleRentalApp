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
            Rents rent = Rents.MapDataToObject(Convert.ToInt32(txtRentID.Text));
            rent.PrintReceipExcel(rent);
        }
    }
}
