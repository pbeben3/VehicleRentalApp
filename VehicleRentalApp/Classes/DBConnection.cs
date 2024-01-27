using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalApp.Classes
{
    public static class DBConnection
    {
        private static readonly string connectionString = "Data Source=LEGION;Initial Catalog=VehicleRental;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
