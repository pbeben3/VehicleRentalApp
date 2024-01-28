using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRentalApp.Classes;

namespace VehicleRentalApp.Interfaces
{
    internal interface IUserDatabaseManager
    {
        public void AddUserToDatabase(User user);
        public void DeleteUserFromDatabase(int id);
        public DataTable ShowUsersData();
        public bool CheckIDAvailability(int x);
    }
}
