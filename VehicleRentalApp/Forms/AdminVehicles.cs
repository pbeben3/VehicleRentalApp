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

namespace VehicleRentalApp
{
    public partial class AdminVehicles : Form
    {
        public AdminVehicles()
        {
            InitializeComponent();
        }

        private void labelMenu_Click(object sender, EventArgs e)
        {
            AdminMenu formAdminMenu = new AdminMenu();
            formAdminMenu.Show();
            this.Close();
        }

        private void AdminUsers_Load(object sender, EventArgs e)
        {
            dataCars.DataSource = Car.ShowVehicleData();
            dataMotorcycles.DataSource = Motorcycle.ShowVehicleData();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            AddCar addCar = new AddCar();
            addCar.Show();

        }

        private void btnAddMotorcycle_Click(object sender, EventArgs e)
        {
            AddMotorcycle addCar = new AddMotorcycle();
            addCar.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataCars.DataSource = Car.ShowVehicleData();
            dataMotorcycles.DataSource = Motorcycle.ShowVehicleData();
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            if (Car.CheckIDAvailability(Convert.ToInt32(txtDeleteCar.Text)) == true || string.IsNullOrWhiteSpace(txtDeleteCar.Text))
            {
                ErrorProvider errorProvider1 = new ErrorProvider();
                errorProvider1.SetError(txtDeleteCar, "Niepoprawne ID");
            }
            else
            {
                Car.DeleteVehicle(Convert.ToInt32(txtDeleteCar.Text));
                MessageBox.Show("Samochód usunięty z bazy danych");
                dataCars.DataSource = Car.ShowVehicleData();
            }
        }

        private void btnDeleteMotorcycle_Click(object sender, EventArgs e)
        {
            if (Motorcycle.CheckIDAvailability(Convert.ToInt32(txtDeleteMotorcycle.Text)) == true || string.IsNullOrWhiteSpace(txtDeleteMotorcycle.Text))
            {
                ErrorProvider errorProvider2 = new ErrorProvider();
                errorProvider2.SetError(txtDeleteMotorcycle, "Niepoprawne ID");
            }
            else
            {
                Motorcycle.DeleteVehicle(Convert.ToInt32(txtDeleteMotorcycle.Text));
                MessageBox.Show("Motocykl usunięty z bazy danych");
                dataMotorcycles.DataSource = Motorcycle.ShowVehicleData();
            }

        }
    }
}
