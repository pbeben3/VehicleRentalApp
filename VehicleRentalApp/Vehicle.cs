using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalApp
{
    public enum Type
    {
        Car,
        Motorcycle
    }
    public abstract class Vehicle : IVehicleDataProvider
    {
        public int VehicleID { get; set; }
        public int Availability { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int ProductionYear { get; set; }
        public string Color { get; set; }
        public int Power { get; set; }
        public int EngineCapacity { get; set; }
        public int CostPerDay { get; set; }

        protected Vehicle(int vehicleID,int availability, string brand, string model, int productionYear, string color, int power, int engineCapacity, int costPerDay)
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

        public abstract void AddVehicle<T>(T vehicle) where T : Vehicle;

        //public static void DeleteVehicle(int id) { }

        public abstract void UpdateVehicle<T>(T vehicle) where T : Vehicle;

        //public static DataTable ShowVehicleData() {  return new DataTable(); }

    }

}
