using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalApp.Classes
{
    public enum Type
    {
        Car,
        Motorcycle
    }
    public abstract class Vehicle 
    {
        private static readonly VehicleDatabaseManager _databaseManager = new VehicleDatabaseManager();
        public int VehicleID { get; set; }
        public int Availability { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int ProductionYear { get; set; }
        public string Color { get; set; }
        public int Power { get; set; }
        public int EngineCapacity { get; set; }
        public int CostPerDay { get; set; }

        protected Vehicle(int vehicleID, int availability, string brand, string model, int productionYear, string color, int power, int engineCapacity, int costPerDay)
        {
            VehicleID = vehicleID;
            Availability = availability;
            Brand = brand;
            Model = model;
            ProductionYear = productionYear;
            Color = color;
            Power = power;
            EngineCapacity = engineCapacity;
            CostPerDay = costPerDay;
        }

        public static int GetVehicleCost(int id)
        {
            return _databaseManager.GetVehicleCost(id);
        }
        public static bool CheckIDAvailability(int x)
        {
            return _databaseManager.CheckIDAvailability(x);
        }

    }

}
