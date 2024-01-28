using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalApp.Interfaces
{
    internal interface IVehicleDatabaseManager
    {
        public int GetVehicleCost(int id);
        public bool CheckIDAvailability(int x);
    }
}
