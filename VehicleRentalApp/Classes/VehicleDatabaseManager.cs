using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalApp.Classes
{
    internal class VehicleDatabaseManager : Interfaces.IVehicleDatabaseManager
    {
        public int GetVehicleCost(int id)
        {
            string getCostQuery = $"SELECT CostPerDay FROM Vehicles WHERE VehicleID = {id};";
            int cost = 0;
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand getCostCommand = new SqlCommand(getCostQuery, connection))
                {
                    using (SqlDataReader reader = getCostCommand.ExecuteReader())
                    {
                        try
                        {
                            while (reader.Read())
                            {
                                cost = Convert.ToInt32(reader["CostPerDay"]);
                            }
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show($"Błąd: {ex}");
                        }
                    }
                }
            }
            return cost;
        }
        public bool CheckIDAvailability(int x)
        {
            string checkIdQuery = $"SELECT COUNT(*) FROM Vehicles WHERE VehicleID={x};";
            using (SqlConnection connection = DBConnection.GetConnection())
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
