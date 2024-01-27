using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            DateTime RentDateParsed;
            DateTime ReturnDateParsed;
            DateTime.TryParseExact(txtRentDate.Text, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out RentDateParsed);
            DateTime.TryParseExact(txtReturnDate.Text, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out ReturnDateParsed);
            Rents rent = new Rents(Rents.GetNewID(), CurrentLoggedUserID, Convert.ToInt32(txtMotorcycleID.Text), RentDateParsed, ReturnDateParsed);
            rent.AddRentToDatabase(rent);
            dataMotorcycles.DataSource = Motorcycle.ShowAvailableMotorcyclesData();
        }
    }
}
