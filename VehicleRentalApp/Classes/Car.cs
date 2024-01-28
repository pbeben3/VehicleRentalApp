using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalApp.Classes
{
    internal class Car : Vehicle
    {
        private static readonly CarDatabaseManager _databaseManager = new CarDatabaseManager();
        public string BodyType { get; set; }
        public string Fuel { get; set; }
        public int Doors { get; set; }
        public string Gearbox { get; set; }


        public Car(int vehicleID, int availability, string brand, string model, int productionYear, string color, int power, int engineCapacity, string bodyType, string fuel, int doors, string gearbox, int costPerDay)
            : base(vehicleID, availability, brand, model, productionYear, color, power, engineCapacity, costPerDay)
        {
            BodyType = bodyType;
            Fuel = fuel;
            Doors = doors;
            Gearbox = gearbox;
        }

        public  void AddVehicle(Car car)
        {
            _databaseManager.AddCarToDatabase(car);
        }
        public static void DeleteVehicle(int id)
        {
            _databaseManager.DeleteCarFromDatabase(id);
        }

        public static DataTable ShowVehicleData()
        {
            return _databaseManager.ShowCarsData();

        }

        public static DataTable ShowAvailableCarData()
        {
            return _databaseManager.ShowAvailableCarsData();
        }
    }

}
