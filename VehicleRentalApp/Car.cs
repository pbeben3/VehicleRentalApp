using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalApp
{
    internal class Car : Vehicle
    {
        public string BodyType { get; set; }
        public string Fuel { get; set; }
        public int Doors { get; set; }
        public string Gearbox { get; set; }


        public Car(int vehicleID,int availability, string brand,string model,int productionYear,string color, int power, int engineCapacity,string bodyType, string fuel, int doors, string gearbox, int costPerDay)
            : base (vehicleID, availability, brand, model, productionYear, color, power, engineCapacity, costPerDay )
        {
            BodyType = bodyType;
            Fuel = fuel;
            Doors = doors;
            Gearbox = gearbox;
        }

        public override void  AddVehicle<T>(T Vehicle) 
        {
            if (Vehicle is Car car)
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
        }
        public static void DeleteVehicle(int id)
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
        public override void UpdateVehicle<T>(T vehicle)
        {

        }
        public  static DataTable ShowVehicleData()
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
        public static DataTable ShowAvailableCarData()
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
