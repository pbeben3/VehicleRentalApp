using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace VehicleRentalApp
{

    public partial class Login : Form
    {
        private int CurrentLoggedUserID { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int authentication = Classes.LoginManager.UserAuthentication(txtLogin.Text, txtPassword.Text);

            if (authentication > 0)
            {
                if (authentication == 1)
                {
                    AdminMenu formAdmin = new AdminMenu();
                    formAdmin.Show();
                    this.Hide();
                }
                else
                {
                    UserMenu form = new UserMenu(authentication);
                    form.Show();
                    this.Hide();
                }
            }
        }
    }
}
