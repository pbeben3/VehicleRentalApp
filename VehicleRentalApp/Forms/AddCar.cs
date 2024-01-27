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
    public partial class AddCar : Form
    {
        public AddCar()
        {
            InitializeComponent();
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool validateCar()
        {
            bool validationPositive = true;
            // VehicleID valdiation
            if (Car.CheckIDAvailability(Convert.ToInt32(txtVehicleID.Text)) != true)
            {
                ErrorProvider errorProvider = new ErrorProvider();
                errorProvider.SetError(txtVehicleID, "ID pojazdu już istnieje w bazie danych");
                validationPositive = false;
            }
            // Brand valdiation
            if (txtBrand.Text == "" || txtBrand.Text.Length < 3)
            {
                ErrorProvider errorProvider1 = new ErrorProvider();
                errorProvider1.SetError(txtBrand, "Niepoprawna nazwa samochodu");
                validationPositive = false;
            }
            // Model validation
            if (txtModel.Text == "" || txtModel.Text.Length < 2)
            {
                ErrorProvider errorProvider2 = new ErrorProvider();
                errorProvider2.SetError(txtModel, "Niepoprawna nazwa modelu");
                validationPositive = false;
            }
            // ProductionYear validation
            int currentYear = DateTime.Now.Year;
            if (TxtPYear.Text == "" || Convert.ToInt32(TxtPYear.Text) < 0 || Convert.ToInt32(TxtPYear.Text) > currentYear)
            {
                ErrorProvider errorProvider3 = new ErrorProvider();
                errorProvider3.SetError(TxtPYear, "Niepoprawny rok produkcji");
                validationPositive = false;
            }
            // Color validation
            if (txtColor.Text == "")
            {
                ErrorProvider errorProvider4 = new ErrorProvider();
                errorProvider4.SetError(txtColor, "Niepoprawny kolor");
                validationPositive = false;
            }
            // Power validaiton
            if (txtPower.Text == "" || Convert.ToInt32(txtPower.Text) < 0)
            {
                ErrorProvider errorProvider5 = new ErrorProvider();
                errorProvider5.SetError(txtPower, "Niepoprawna moc");
                validationPositive = false;
            }
            // EngineCapacity validation
            if (txtECapacity.Text == "" || Convert.ToInt32(txtECapacity.Text) < 0)
            {
                ErrorProvider errorProvider6 = new ErrorProvider();
                errorProvider6.SetError(txtECapacity, "Niepoprawna pojemność");
                validationPositive = false;
            }
            // CostPerDay validation
            if (txtCostPerDay.Text == "" || Convert.ToInt32(txtCostPerDay.Text) < 0)
            {
                ErrorProvider errorProvider7 = new ErrorProvider();
                errorProvider7.SetError(txtCostPerDay, "Niepoprawy dzienny koszt wypożyczenia");
                validationPositive = false;
            }
            //BodyType validation
            if (txtBType.Text == "" || txtBType.Text.Length < 4)
            {
                ErrorProvider errorProvider8 = new ErrorProvider();
                errorProvider8.SetError(txtBType, "Niepoprawy typ nadwozia samochodu");
                validationPositive = false;
            }
            //Fuel validation
            if (txtFuel.Text == "" || txtFuel.Text.Length < 2)
            {
                ErrorProvider errorProvider9 = new ErrorProvider();
                errorProvider9.SetError(txtFuel, "Niepoprawy typ paliwa");
                validationPositive = false;
            }
            //Doors validation
            if (txtDoors.Text == "" || Convert.ToInt32(txtDoors.Text) < 2)
            {
                ErrorProvider errorProvider10 = new ErrorProvider();
                errorProvider10.SetError(txtDoors, "Niepoprawna ilość drzwi");
                validationPositive = false;
            }
            // Gearbox validation
            if (txtGearbox.Text == "" || txtGearbox.Text.Length < 1)
            {
                ErrorProvider errorProvider10 = new ErrorProvider();
                errorProvider10.SetError(txtGearbox, "Niepoprawna skrzynia biegów");
                validationPositive = false;
            }
            return validationPositive;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (validateCar() == true)
            {
                Car car = new Car(Convert.ToInt32(txtVehicleID.Text), 1, txtBrand.Text, txtModel.Text, Convert.ToInt32(TxtPYear.Text), txtColor.Text, Convert.ToInt32(txtPower.Text), Convert.ToInt32(txtECapacity.Text), txtBType.Text, txtFuel.Text, Convert.ToInt32(txtDoors.Text), txtGearbox.Text, Convert.ToInt32(txtCostPerDay.Text));
                car.AddVehicle(car);
                MessageBox.Show("Pomyślnie dodano samochód, odśwież bazę");
                this.Close();
            }
            else
            {
                MessageBox.Show("Wprowadź poprawne dane");
            }
        }
    }
}
