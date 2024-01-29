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
    public partial class UserCars : Form
    {
        private int CurrentLoggedUserID { get; set; }
        public UserCars(int currentLoggedUserID)
        {
            InitializeComponent();
            CurrentLoggedUserID = currentLoggedUserID;
        }

        private void UserCars_Load(object sender, EventArgs e)
        {
            dataCars.DataSource = Car.ShowAvailableCarData();
        }

        private void labelMenu_Click(object sender, EventArgs e)
        {
            UserMenu userMenu = new UserMenu(CurrentLoggedUserID);
            userMenu.Show();
            this.Close();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (validateCarBook() == true)
            {
                DateTime RentDateParsed;
                DateTime ReturnDateParsed;
                DateTime.TryParseExact(txtRentDate.Text, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out RentDateParsed);
                DateTime.TryParseExact(txtReturnDate.Text, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out ReturnDateParsed);
                Rents rent = new Rents(Rents.GetNewID(), CurrentLoggedUserID, Convert.ToInt32(txtCarID.Text), RentDateParsed, ReturnDateParsed);
                rent.AddRentToDatabase(rent);
                dataCars.DataSource = Car.ShowAvailableCarData();
            }
            else
            {
                MessageBox.Show("Niepoprawne dane wypożyczenia");
            }

        }
        private bool validateCarBook()
        {

            bool validationPositive = true;
            DateTime RentDateParsed;
            DateTime ReturnDateParsed;
            DateTime.TryParseExact(txtRentDate.Text, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out RentDateParsed);
            DateTime.TryParseExact(txtReturnDate.Text, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out ReturnDateParsed);
            if (string.IsNullOrWhiteSpace(txtCarID.Text) || !int.TryParse(txtCarID.Text, out _))
            {
                ErrorProvider errorProvider = new ErrorProvider();
                errorProvider.SetError(txtCarID, "Niepoprawne ID pojazdu");
                validationPositive = false;
            }
            if (string.IsNullOrWhiteSpace(txtRentDate.Text) || RentDateParsed < DateTime.Today)
            {
                ErrorProvider errorProvider1 = new ErrorProvider();
                errorProvider1.SetError(txtRentDate, "Niepoprawna data, podaj w formacie YYYY-MM-DD");
                validationPositive = false;
            }
            if (string.IsNullOrWhiteSpace(txtReturnDate.Text) || ReturnDateParsed < DateTime.Today)
            {
                ErrorProvider errorProvider2 = new ErrorProvider();
                errorProvider2.SetError(txtReturnDate, "Niepoprawna data zwrotu, podaj w formacie YYYY-MM-DD");
                validationPositive = false;
            }
            return validationPositive;
        }
    }
}
