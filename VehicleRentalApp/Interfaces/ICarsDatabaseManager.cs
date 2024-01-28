using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRentalApp.Classes;

namespace VehicleRentalApp.Interfaces
{
    internal interface ICarsDatabaseManager
    {
        public void AddCarToDatabase(Car car);
        public void DeleteCarFromDatabase(int id);
        public DataTable ShowCarsData();
        public DataTable ShowAvailableCarsData();
    }
}
