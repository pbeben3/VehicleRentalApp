using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRentalApp.Classes;

namespace VehicleRentalApp.Interfaces
{
    internal interface IMotorcyclesDatabaseManager
    {
        public void AddMotorcycleToDatabase(Motorcycle motorcycle);
        public void DeleteMotorcycleFromDatabase(int id);
        public DataTable ShowMotorcyclesData();
        public DataTable ShowAvailableMotorcyclesData();
    }
}
