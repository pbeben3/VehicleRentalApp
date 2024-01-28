using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRentalApp.Interfaces;

namespace VehicleRentalApp.Classes
{
    internal class MotorcycleDatabaseManager : IMotorcyclesDatabaseManager
    {
        public void AddMotorcycleToDatabase(Motorcycle motorcycle)
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
        public void DeleteMotorcycleFromDatabase(int id)
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
        public DataTable ShowMotorcyclesData()
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
        public DataTable ShowAvailableMotorcyclesData()
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
