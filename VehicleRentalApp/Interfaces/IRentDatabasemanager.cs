using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRentalApp.Classes;

namespace VehicleRentalApp.Interfaces
{
    internal interface IRentDatabasemanager
    {
        public void AddRentToDatabase(Rents rent);
        public Rents MapDataToObject(int id);
        public void FinishRent(Rents rent);
        public int GetNewID();
        public DataTable GetActiveRentsData();
        public DataTable GetFinishedRentsData();
        public DataTable GetUserRentsData(int id);

    }
}
