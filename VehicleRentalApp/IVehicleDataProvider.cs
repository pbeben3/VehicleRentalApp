using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalApp
{
    internal interface IVehicleDataProvider
    {
        void AddVehicle<T>(T vehicle) where T : Vehicle;
        void UpdateVehicle<T>(T vehicle) where T : Vehicle;
        // void DeleteVehicle(int id);
        //DataTable ShowVehicleData();
    }

}
