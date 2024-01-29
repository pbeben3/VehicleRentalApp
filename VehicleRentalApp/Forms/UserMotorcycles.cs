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
    public partial class UserMotorcycles : Form
    {
        private int CurrentLoggedUserID { get; set; }
        public UserMotorcycles(int currentLoggedUserID)
        {
            InitializeComponent();
            CurrentLoggedUserID = currentLoggedUserID;
        }

        private void UserMotorcycles_Load(object sender, EventArgs e)
        {
            dataMotorcycles.DataSource = Motorcycle.ShowAvailableMotorcyclesData();
        }

        private void labelMenu_Click(object sender, EventArgs e)
        {
            UserMenu userMenu = new UserMenu(CurrentLoggedUserID);
            userMenu.Show();
            this.Close();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (validateMotorcycleBook() == true)
            {
                DateTime RentDateParsed;
                DateTime ReturnDateParsed;
                DateTime.TryParseExact(txtRentDate.Text, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out RentDateParsed);
                DateTime.TryParseExact(txtReturnDate.Text, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out ReturnDateParsed);
                Rents rent = new Rents(Rents.GetNewID(), CurrentLoggedUserID, Convert.ToInt32(txtMotorcycleID.Text), RentDateParsed, ReturnDateParsed);
                rent.AddRentToDatabase(rent);
                dataMotorcycles.DataSource = Motorcycle.ShowAvailableMotorcyclesData();
            }
            else
            {
                MessageBox.Show("Niepoprawne dane wypożyczenia");
            }
        }
        private bool validateMotorcycleBook()
        {

            bool validationPositive = true;
            DateTime RentDateParsed;
            DateTime ReturnDateParsed;
            DateTime.TryParseExact(txtRentDate.Text, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out RentDateParsed);
            DateTime.TryParseExact(txtReturnDate.Text, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out ReturnDateParsed);
            if (string.IsNullOrWhiteSpace(txtMotorcycleID.Text) || !int.TryParse(txtMotorcycleID.Text, out _))
            {
                ErrorProvider errorProvider = new ErrorProvider();
                errorProvider.SetError(txtMotorcycleID, "Niepoprawne ID pojazdu");
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
