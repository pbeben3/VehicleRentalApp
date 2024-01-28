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
    internal class CarDatabaseManager : ICarsDatabaseManager
    {
        public  void AddCarToDatabase(Car car)
        {

                string insertCarQuery = $"Insert INTO Vehicles (VehicleID,Availability, Brand, Model, ProductionYear, Color, Power, EngineCapacity, CostPerDay) VALUES ('{car.VehicleID}','{car.Availability}', '{car.Brand}', '{car.Model}', {car.ProductionYear}, '{car.Color}', {car.Power}, {car.EngineCapacity}, {car.CostPerDay}); INSERT INTO Cars(VehicleID, BodyType, Fuel, Doors, Gearbox) VALUES ({car.VehicleID}, '{car.BodyType}', '{car.Fuel}', {car.Doors}, '{car.Gearbox}')";
                using (SqlConnection connection = DBConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand insertCarCommand = new SqlCommand(insertCarQuery, connection))
                    {
                        try
                        {
                            insertCarCommand.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show($"Błąd przy dodawaniu samochodu do bazy danych:{ex}");
                        }
                    }
                }          
        }

        public void DeleteCarFromDatabase(int id)
        {
            string deleteCarQuery = $"DELETE FROM Cars WHERE VehicleID = {id}; DELETE FROM Vehicles WHERE VehicleID = {id}; ";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand deleteCarCommand = new SqlCommand(deleteCarQuery, connection))
                {
                    try
                    {
                        deleteCarCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show($"Błąd przy usuwaniu samochodu z bazy danych: {ex}");
                    }
                }
            }
        }

        public  DataTable ShowCarsData()
        {
            string showCarsQuery = $"SELECT V.VehicleID, V.Availability, V.Brand, V.Model, V.ProductionYear, V.Color, V.Power, V.EngineCapacity, C.BodyType, C.Fuel, C.Doors, C.Gearbox, V.CostPerDay  FROM Vehicles V INNER JOIN Cars C ON V.VehicleID = C.VehicleID;";
            DataTable dt = new DataTable();
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(showCarsQuery, connection);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Błąd podczas ładowania danych samochodów: {ex}");
                }
            }
            return dt;
        }
        public  DataTable ShowAvailableCarsData()
        {
            string showCarsQuery = $"SELECT V.VehicleID, V.Brand, V.Model, V.ProductionYear, V.Color, V.Power, V.EngineCapacity, C.BodyType, C.Fuel, C.Doors, C.Gearbox, V.CostPerDay  FROM Vehicles V INNER JOIN Cars C ON V.VehicleID = C.VehicleID WHERE V.Availability = 1;";
            DataTable dt = new DataTable();
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(showCarsQuery, connection);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Błąd podczas ładowania danych samochodów: {ex}");
                }
            }
            return dt;
        }
    }

}
