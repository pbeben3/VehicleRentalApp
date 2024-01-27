using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalApp.Classes
{
    internal class Motorcycle : Vehicle
    {
        public string Type { get; set; }
        public string EngineType { get; set; }
        public string RequiredLicense { get; set; }


        public Motorcycle(int vehicleID, int availability, string brand, string model, int productionYear, string color, int power, int engineCapacity, string type, string engineType, string requiredLicense, int costPerDay)
            : base(vehicleID, availability, brand, model, productionYear, color, power, engineCapacity, costPerDay)
        {
            Type = type;
            EngineType = engineType;
            RequiredLicense = requiredLicense;
        }

        public override void AddVehicle<T>(T Vehicle)
        {
            if (Vehicle is Motorcycle motorcycle)
            {
                string insertMotorcycleQuery = $"Insert INTO Vehicles (VehicleID, Availability, Brand, Model, ProductionYear, Color, Power, EngineCapacity, CostPerDay) VALUES ({motorcycle.VehicleID}, '{motorcycle.Availability}' , '{motorcycle.Brand}', '{motorcycle.Model}', {motorcycle.ProductionYear}, '{motorcycle.Color}', {motorcycle.Power}, {motorcycle.EngineCapacity}, {motorcycle.CostPerDay}); INSERT INTO Motorcycles (VehicleID, Type, EngineType, RequiredLicense) VALUES ({motorcycle.VehicleID}, '{motorcycle.Type}', '{motorcycle.EngineType}', '{motorcycle.RequiredLicense}')";
                using (SqlConnection connection = DBConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand insertCarCommand = new SqlCommand(insertMotorcycleQuery, connection))
                    {
                        try
                        {
                            insertCarCommand.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show($"Błąd przy dodawaniu motocykla do bazy danych:{ex}");
                        }
                    }
                }
            }
        }
        public static void DeleteVehicle(int id)
        {
            string deleteMotorcycleQuery = $"DELETE FROM Motorcycles WHERE VehicleID = {id}; DELETE FROM Vehicles WHERE VehicleID = {id}; ";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand deleteCarCommand = new SqlCommand(deleteMotorcycleQuery, connection))
                {
                    try
                    {
                        deleteCarCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show($"Błąd przy usuwaniu motocykla z bazy danych: {ex}");
                    }
                }
            }
        }
        public override void UpdateVehicle<T>(T vehicle)
        {

        }
        public static DataTable ShowVehicleData()
        {
            string showMotorcyclesQuery = $"SELECT V.VehicleID, V.Availability, V.Brand, V.Model, V.ProductionYear, V.Color, V.Power, V.EngineCapacity, M.Type, M.EngineType, M.RequiredLicense, V.CostPerDay FROM Vehicles V INNER JOIN Motorcycles M ON V.VehicleID = M.VehicleID;";
            DataTable dt = new DataTable();
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(showMotorcyclesQuery, connection);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Błąd podczas ładowania danych motocykli: {ex}");
                }
            }
            return dt;
        }
        public static bool CheckIDAvailability(int x)
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
        public static DataTable ShowAvailableMotorcyclesData()
        {
            string showMotorcyclesQuery = $"SELECT V.VehicleID, V.Brand, V.Model, V.ProductionYear, V.Color, V.Power, V.EngineCapacity, M.Type, M.EngineType, M.RequiredLicense, V.CostPerDay FROM Vehicles V INNER JOIN Motorcycles M ON V.VehicleID = M.VehicleID WHERE V.Availability = 1;";
            DataTable dt = new DataTable();
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(showMotorcyclesQuery, connection);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Błąd podczas ładowania danych motocykli: {ex}");
                }
            }
            return dt;
        }
    }

}
