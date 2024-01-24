using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalApp
{
    public enum Role
    {
        Admin,
        Client
    }
    internal class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Role Role { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

 
        public User(int userId, string name, string lastName, int age, string adress, string email, string phoneNumber, Role role, string login, string password)
        {
            UserId = userId;
            Name = name;
            LastName = lastName;
            Age = age;
            Adress = adress;
            Email = email;
            PhoneNumber = phoneNumber;
            Role = role;
            Login = login;
            Password = password;
        }


        public static void DeleteUserFromDatabase(int id)
        {
            using (SqlConnection connection = DBConnection.GetConnection())
            {

                    connection.Open();
                    string deleteUserQuery = $"DELETE From Users WHERE UserID={id};";
                    using (SqlCommand deleteUserCommand = new SqlCommand(deleteUserQuery, connection))
                    {
                        try
                        {
                            deleteUserCommand.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine($"Błąd przy usuwaniu z bazy danych użytkolwnika: {ex}");
                        }
                    }
                

            }
        }
        public void AddUserToDatabase(User user)
        {
            string insertUserQuery = $"INSERT INTO Users (UserID, Name, LastName, Age, Adress, Email, PhoneNumber, Role, Login, Password) VALUES ('{user.UserId}', '{user.Name}', '{user.LastName}', '{user.Age}', '{user.Adress}', '{user.Email}', '{user.PhoneNumber}', '{user.Role}', '{user.Login}', '{user.Password}');";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand insertUserCommand = new SqlCommand(insertUserQuery, connection))
                {
                    try
                    {
                        insertUserCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show($"Błąd przy dodawaniu do bazy danych:{ex}");
                    }
                }
            }
        }

        public static  DataTable ShowUsersData()
        {
            string showUsersQuery = $"SELECT * FROM Users;";
            DataTable dt = new DataTable();
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(showUsersQuery, connection);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Błąd podczas ładowania danych użytkowników: {ex}");
                }
            }
            return dt;
        }

        public static bool CheckIDAvailability(int x)
        {
            string checkIdQuery = $"SELECT COUNT(*) FROM Users WHERE UserID={x};";
            using(SqlConnection connection = DBConnection.GetConnection()) 
            { 
                connection.Open();
                using (SqlCommand checkIdCommand = new SqlCommand(checkIdQuery, connection))
                {
                    int count = Convert.ToInt32(checkIdCommand.ExecuteScalar());
                    if (count == 0)
                    {
                        return true;
                    }
                    else 
                    {
                        return false;
                    }
                }
            }
        } 



    }

}
