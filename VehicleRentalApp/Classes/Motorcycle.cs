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
        private static readonly MotorcycleDatabaseManager _databaseManager = new MotorcycleDatabaseManager();
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

        public  void AddVehicle(Motorcycle motorcycle)
        {
            _databaseManager.AddMotorcycleToDatabase(motorcycle);
        }
        public static void DeleteVehicle(int id)
        {
            _databaseManager.DeleteMotorcycleFromDatabase(id);
        }

        public static DataTable ShowVehicleData()
        {
            return _databaseManager.ShowMotorcyclesData();
        }

        public static DataTable ShowAvailableMotorcyclesData()
        {
            return _databaseManager.ShowAvailableMotorcyclesData();
        }
    }

}
