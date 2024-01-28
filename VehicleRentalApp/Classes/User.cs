using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalApp.Classes
{
    public enum Role
    {
        Admin,
        Client
    }
    internal class User
    {
        private static readonly UserDatabaseManager _databaseManager = new UserDatabaseManager();
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
            _databaseManager.DeleteUserFromDatabase(id);
        }
        public void AddUserToDatabase(User user)
        {
            _databaseManager.AddUserToDatabase(user);
        }

        public static DataTable ShowUsersData()
        {
            return _databaseManager.ShowUsersData();
        }

        public static bool CheckIDAvailability(int x)
        {
            return _databaseManager.CheckIDAvailability(x);
        }



    }

}
