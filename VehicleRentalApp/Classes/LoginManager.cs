using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalApp.Classes
{
    internal class LoginManager
    {
        public static int UserAuthentication (string login, string password)
        {
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Podaj login i hasło!");
                return -1; 
            }
            // repaired
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                string selectDataQuery = $"SELECT * FROM Users WHERE Login='{login}' and Password='{password}'";

                using (SqlCommand selectDataCommand = new SqlCommand(selectDataQuery, connection))
                {
                    using (SqlDataReader reader = selectDataCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            reader.Close();
                            string selectRoleQuery = $"SELECT Role FROM Users WHERE Login='{login}' and Password='{password}'";

                            using (SqlCommand selectRoleCommand = new SqlCommand(selectRoleQuery, connection))
                            {
                                string role = Convert.ToString(selectRoleCommand.ExecuteScalar());
                                if (role == "admin")
                                {
                                    return 1; 
                                }
                                else
                                {
                                    string getUserIDQuery = $"SELECT UserID FROM Users WHERE Login='{login}' and Password='{password}'";

                                    using (SqlCommand getUserIDCommand = new SqlCommand(getUserIDQuery, connection))
                                    {
                                        return Convert.ToInt32(getUserIDCommand.ExecuteScalar());
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Niepoprawny login lub hasło. Podaj poprawne dane!");
                            return -1; 
                        }
                    }
                }
            }
        }
    }
}
