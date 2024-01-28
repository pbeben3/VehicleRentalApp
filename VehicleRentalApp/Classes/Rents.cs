using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;

namespace VehicleRentalApp.Classes
{
    internal class Rents
    {
        private static readonly RentDatabaseManager _databaseManager = new RentDatabaseManager();
        public int RentID { get; set; }
        public int UserID { get; set; }
        public int VehicleID { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int Cost { get; set; }
        public string Finished { get; set; }
        public int Fine { get; set; }

        public Rents(int rentID, int userID, int vehicleID, DateTime rentDate, DateTime returnDate, int cost = 0, string finished = "No", int fine = 0)
        {
            RentID = rentID;
            UserID = userID;
            VehicleID = vehicleID;
            RentDate = rentDate;
            ReturnDate = returnDate;
            Cost = cost;
            Finished = finished;
            Fine = fine;
        }
        public void AddRentToDatabase(Rents rent)
        {
            _databaseManager.AddRentToDatabase(rent);
        }
        public static Rents MapDataToObject(int id)
        {
            return _databaseManager.MapDataToObject(id);
        }
        public void FinishRent(Rents rent)
        {
            _databaseManager.FinishRent(rent);
        }
        public static int GetNewID()
        {
            return _databaseManager.GetNewID();
        }
        public static DataTable GetActiveRentsData()
        {
            return _databaseManager.GetActiveRentsData();
        }
        public static DataTable GetFinishedRentsData()
        {
            return _databaseManager.GetFinishedRentsData();
        }
        public static DataTable GetUserRentsData(int id)
        {
            return _databaseManager.GetUserRentsData(id);
        }

        public void PrintReceipExcel(Rents rent)
        {
            string filePath = Path.Combine(Environment.CurrentDirectory, "Paragon.xlsx");
            DateTime data = DateTime.Now;
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage())
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Paragon");

                worksheet.Cells["A1"].Value = "Paragon fiskalny";

                worksheet.Cells["A2"].Value = "Wystawiający";
                worksheet.Cells["B2"].Value = "VehicleRental S.A";

                worksheet.Cells["A3"].Value = "ID klienta:";
                worksheet.Cells["B3"].Value = rent.UserID;

                worksheet.Cells["A4"].Value = "Kwota do zapłaty:";
                worksheet.Cells["B4"].Value = rent.Cost;

                worksheet.Cells["A5"].Value = "Data wystawienia:";
                worksheet.Cells["B5"].Value = data;

                package.SaveAs(new FileInfo(filePath));
            }
            MessageBox.Show("Paragon został zapisany do pliku .xls o ścieżce: repos\\VehicleRentalApp\\VehicleRentalApp\\bin\\Debug\\net7.0-windows\\Paragon.xlsx\" ");
        }
    }


}
