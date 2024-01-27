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
            string connectionString = "Data Source=LEGION;Initial Catalog=VehicleRental;Integrated Security=True";
            if (txtLogin.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Podaj login i hasło!");
            }
            else if (txtLogin.Text == "")
            {
                MessageBox.Show("Podaj login!");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Podaj hasło!");
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string selectDataQuery = "SELECT * FROM Users WHERE Login='" + txtLogin.Text + "' and Password='" + txtPassword.Text + "'";
                    using (SqlCommand selectDataCommand = new SqlCommand(selectDataQuery, connection))
                    {
                        using (SqlDataReader reader = selectDataCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                reader.Close();
                                string selectRoleQuery = "SELECT Role FROM Users WHERE Login='" + txtLogin.Text + "' and Password='" + txtPassword.Text + "'";
                                using (SqlCommand selectRoleCommand = new SqlCommand(selectRoleQuery, connection))
                                {
                                    string role = Convert.ToString(selectRoleCommand.ExecuteScalar());
                                    if (role == "admin")
                                    {
                                        AdminMenu formAdmin = new AdminMenu();
                                        formAdmin.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        string getUserIDQuery = "SELECT UserID FROM Users WHERE Login='" + txtLogin.Text + "' and Password='" + txtPassword.Text + "'";
                                        using (SqlCommand getUserIDCommand = new SqlCommand(getUserIDQuery, connection))
                                        {
                                            CurrentLoggedUserID = Convert.ToInt32(getUserIDCommand.ExecuteScalar());
                                        }
                                        UserMenu form = new UserMenu(CurrentLoggedUserID);
                                        form.Show();
                                        this.Hide();
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Niepoprawny login lub hasło. Podaj poprawne dane!");
                                txtLogin.Clear();
                                txtPassword.Clear();
                            }
                        }
                    }
                }
            }
        }
    }
}
