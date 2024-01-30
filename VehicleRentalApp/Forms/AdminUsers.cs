using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using VehicleRentalApp.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace VehicleRentalApp
{
    public partial class AdminUsers : Form
    {
        public AdminUsers()
        {
            InitializeComponent();
        }

        private void AdminUsers_Load(object sender, EventArgs e)
        {
            dataUsers.DataSource = Classes.User.ShowUsersData();
        }

        private void labelMenu_Click(object sender, EventArgs e)
        {
            AdminMenu formAdminMenu = new AdminMenu();
            formAdminMenu.Show();
            this.Close();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (validateAdedUser() == true)
            {
                Classes.User user1 = new Classes.User(Convert.ToInt32(txtUserID.Text), txtName.Text, txtLastName.Text, Convert.ToInt32(txtAge.Text), txtAdress.Text, txtEmail.Text, txtPhoneNumber.Text, (Role)Enum.Parse(typeof(Role), txtRole.Text), txtLogin.Text, txtPassword.Text);
                user1.AddUserToDatabase(user1);
                MessageBox.Show("Uzytkownik dodany do bazy");
                dataUsers.DataSource =  Classes.User.ShowUsersData();
            }
            else
            {
                MessageBox.Show("Dane niepoprawne. Popraw zaznaczone pola.");
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (Classes.User.CheckIDAvailability(Convert.ToInt32(txtDeleteUserID.Text)) == false || !string.IsNullOrWhiteSpace(txtDeleteUserID.Text))
            {
                MessageBox.Show("Uzytkownik o takim ID nie jest zapisany w bazie");
            }
            else
            {
                Classes.User.DeleteUserFromDatabase(Convert.ToInt32(txtDeleteUserID.Text));
                MessageBox.Show("Uzytkownik usunięty z bazy danych");
                dataUsers.DataSource = Classes.User.ShowUsersData();
            }

        }
        private bool validateAdedUser()
        {
            bool validationPositive = true;
            // UserID validation
            if (Classes.User.CheckIDAvailability(Convert.ToInt32(txtUserID.Text)) != true || string.IsNullOrWhiteSpace(txtUserID.Text))
            {
                ErrorProvider errorProvider = new ErrorProvider();
                errorProvider.SetError(txtUserID, "To ID użytkownika już istnieje w bazie danych");
                validationPositive = false;
            }
            // Name validation
            if (!Regex.IsMatch(txtName.Text, @"^[a-zA-Z]+$") || txtName.Text.Length < 2 || string.IsNullOrWhiteSpace(txtName.Text))
            {
                ErrorProvider errorProvider1 = new ErrorProvider();
                errorProvider1.SetError(txtName, "Błędne imie");
                validationPositive = false;
            }
            // LastName validation 
            if (!Regex.IsMatch(txtLastName.Text, @"^[a-zA-Z]+$") || txtLastName.Text.Length < 2 || string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                ErrorProvider errorProvider2 = new ErrorProvider();
                errorProvider2.SetError(txtLastName, "Błędne Nazwisko");
                validationPositive = false;
            }
            // Age validation
            if (Convert.ToInt32(txtAge.Text) < 18 || string.IsNullOrWhiteSpace(txtAge.Text))
            {
                ErrorProvider errorProvider3 = new ErrorProvider();
                errorProvider3.SetError(txtAge, "Błędny wiek");
                validationPositive = false;
            }
            // Adress validation
            if (!Regex.IsMatch(txtAdress.Text, @"[a-zA-Z]") || !Regex.IsMatch(txtAdress.Text, @"\d") || string.IsNullOrWhiteSpace(txtAdress.Text))
            {
                ErrorProvider errorProvider4 = new ErrorProvider();
                errorProvider4.SetError(txtAdress, "Adres składa się z co najmniej jednej litery i jednej cyfry");
                validationPositive = false;
            }
            // Email validation
            if (!txtEmail.Text.Contains("@") || txtEmail.Text.Length < 5 || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                ErrorProvider errorProvider5 = new ErrorProvider();
                errorProvider5.SetError(txtEmail, "Niepoprawny Email");
                validationPositive = false;
            }
            // PhoneNumber validation
            if(txtPhoneNumber.Text.Length != 9 || !txtPhoneNumber.Text.All(Char.IsDigit) || string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                ErrorProvider errorProvider6 = new ErrorProvider();
                errorProvider6.SetError(txtPhoneNumber, "Niepoprawny numer telefonu");
                validationPositive = false;
            }
            // Role validation
            if (Enum.TryParse<Role>(txtRole.Text, out _) == false || string.IsNullOrWhiteSpace(txtRole.Text))
            {
                ErrorProvider errorProvider7 = new ErrorProvider();
                errorProvider7.SetError(txtRole, "Niepoprawna rola");
                validationPositive = false;
            }
            //Login validation 
            if (txtLogin.Text.Length < 4 || string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                ErrorProvider errorProvider8 = new ErrorProvider();
                errorProvider8.SetError(txtLogin, "Niepoprawny login");
                validationPositive = false;
            }
            //Password validation 
            if (txtPassword.Text.Length < 6 || !txtPassword.Text.Any(char.IsDigit) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                ErrorProvider errorProvider9 = new ErrorProvider();
                errorProvider9.SetError(txtPassword, "Niepoprawne hasło");
                validationPositive = false;
            }
            return validationPositive;
        }
    }
}
