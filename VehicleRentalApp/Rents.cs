using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalApp
{
    internal class Rents
    {
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
            string insertRentQuery = $"INSERT INTO Rents (RentID, UserID, VehicleID, RentDate, ReturnDate, Cost, Finished, Fine) VALUES ('{rent.RentID}', '{rent.UserID}', '{rent.VehicleID}', '{rent.RentDate.ToString("yyyy-MM-dd")}', '{rent.ReturnDate.ToString("yyyy-MM-dd")}', '{rent.Cost}', '{rent.Finished}', '{rent.Fine}')";
            string changeAvailabilityQuery = $"UPDATE Vehicles SET Availability = 0 Where VehicleID = {rent.VehicleID};";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand insertRentCommand = new SqlCommand(insertRentQuery, connection))
                {
                    try
                    {
                        insertRentCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show($"Błąd przy dodawaniu do bazy danych:{ex}");
                    }
                }
                using (SqlCommand changeAvailabilityCommand = new SqlCommand(changeAvailabilityQuery, connection))
                {
                    try
                    {
                        changeAvailabilityCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show($"Błąd przy zmienianiu statusu samochodu:{ex}");
                    }
                }
            }
        }
        public static void MapDataToObject(int id)
        {
            string getDataQuery = $"SELECT RentID, UserID, VehicleID, RentDate, ReturnDate, Cost, Finished, Fine FROM Rents WHERE RentID = {id}";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand getDataCommand = new SqlCommand(getDataQuery, connection))
                {
                    using (SqlDataReader reader = getDataCommand.ExecuteReader())
                    {
                        try
                        {
                            while (reader.Read())
                            {
                                int rentID = Convert.ToInt32(reader["RentID"]);
                                int userID = Convert.ToInt32(reader["UserID"]);
                                int vehicleID = Convert.ToInt32(reader["VehicleID"]);
                                DateTime rentDate = Convert.ToDateTime(reader["RentDate"]);
                                DateTime returnDate = Convert.ToDateTime(reader["ReturnDate"]);
                                int cost = Convert.ToInt32(reader["Cost"]);
                                string finished = reader["Finished"].ToString();
                                int fine = Convert.ToInt32(reader["Fine"]);
                                Rents rent = new Rents(rentID, userID, vehicleID, rentDate, returnDate, cost, finished, fine);
                            }
                        }
                        catch (Exception ex)
                        {
                            
                            MessageBox.Show($"Błąd: {ex}");
                        }
                    }
                }
            }
        }
        public void FinishRent(Rents rent)
        {
            DateTime currentDate = DateTime.Now;
            int CostPerDay = Vehicle.GetVehicleCost(rent.VehicleID);
            TimeSpan days = rent.ReturnDate.Subtract(currentDate);
            int DifferenceOfDays = days.Days;
            int cost = CostPerDay * DifferenceOfDays;
            if (currentDate.Year != rent.ReturnDate.Year || currentDate.Day != rent.ReturnDate.Day)
            {
                TimeSpan daysWithoutFine = rent.ReturnDate.Subtract(rent.RentDate);
                DifferenceOfDays = daysWithoutFine.Days;
                TimeSpan daysWithFine = rent.ReturnDate.Subtract(currentDate);
                int daysWithFineDifference = daysWithFine.Days;
                cost = (CostPerDay * DifferenceOfDays) + ((CostPerDay * 2) * daysWithFineDifference);
            }

            string finishRentQuery = $"UPDATE Rents SET Cost = {cost}, Finished = 'Yes' WHERE RentID = {rent.RentID};";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand finishRentCommand = new SqlCommand(finishRentQuery, connection))
                {
                    try
                    {
                        finishRentCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show($"Błąd przy kończeniu wypożyczenia: {ex}");
                    }
                }
            }
        }
        public static int GetNewID()
        {
            int newID = 0;
            string selectLastIDQuery = "SELECT TOP 1 RentID FROM Rents ORDER BY RentID DESC;";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectLastIDCommand = new SqlCommand(selectLastIDQuery, connection))
                {
                    using (SqlDataReader reader = selectLastIDCommand.ExecuteReader())
                    {
                        try
                        {
                            while (reader.Read())
                            {
                                newID = Convert.ToInt32(reader["RentID"]);
                            }
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show($"Błąd: {ex}");
                        }
                    }
                }
            }
            return newID+1;
        }

    }
}
