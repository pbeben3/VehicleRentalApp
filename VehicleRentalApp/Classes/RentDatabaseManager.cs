using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalApp.Classes
{
    internal class RentDatabaseManager
    {
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

                        MessageBox.Show($"Błąd przy zmienianiu statusu pojazdu:{ex}");
                    }
                }
            }
        }
        public Rents MapDataToObject(int id)
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
                                return rent;
                            }
                            return null;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Błąd: {ex}");
                            return null;

                        }
                    }
                }
            }
        }
        public void FinishRent(Rents rent)
        {
            DateTime currentDate = DateTime.Now;
            int CostPerDay = Vehicle.GetVehicleCost(rent.VehicleID);
            TimeSpan daysDifference = rent.ReturnDate - rent.RentDate;
            int DifferenceOfDays = daysDifference.Days;
            int cost = CostPerDay * DifferenceOfDays;
            if (currentDate.Year != rent.ReturnDate.Year || currentDate.Day != rent.ReturnDate.Day)
            {
                int daysWithoutFine = DifferenceOfDays;
                TimeSpan daysWithFine = currentDate - rent.ReturnDate;
                int daysWithFineDifference = daysWithFine.Days;
                cost = (CostPerDay * daysWithoutFine) + ((CostPerDay * 2) * daysWithFineDifference);
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
                string changeVehicleStatus = $"UPDATE Vehicles SET Availability = 1 WHERE VehicleID = {rent.VehicleID};";
                using (SqlCommand changeVehicleStatusCommand = new SqlCommand(changeVehicleStatus, connection))
                {
                    try
                    {
                        changeVehicleStatusCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show($"Błąd przy zmianie statusu pojazdu: {ex}");
                    }
                }
            }
        }
        public int GetNewID()
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
            return newID + 1;
        }
        public DataTable GetActiveRentsData()
        {
            string showActiveRentsData = $"SELECT R.RentID, U.UserID, U.Name, U.LastName, R.VehicleID, R.RentDate, R.ReturnDate, R.Cost, R.Finished, R.Fine FROM Rents R inner join Users U on R.UserID=U.UserID WHERE R.Finished = 'No'";
            DataTable dt = new DataTable();
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(showActiveRentsData, connection);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Błąd podczas ładowania danych aktywnych wypożyczeń: {ex}");
                }
            }
            return dt;
        }
        public DataTable GetFinishedRentsData()
        {
            string showFinishedRentsData = $"SELECT R.RentID, U.UserID, U.Name, U.LastName, R.VehicleID, R.RentDate, R.ReturnDate, R.Cost, R.Finished, R.Fine FROM Rents R inner join Users U on R.UserID=U.UserID WHERE R.Finished = 'Yes'";
            DataTable dt = new DataTable();
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(showFinishedRentsData, connection);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Błąd podczas ładowania danych zakończonych wypożyczeń: {ex}");
                }
            }
            return dt;
        }
        public DataTable GetUserRentsData(int id)
        {
            string showUserRentsData = $"SELECT R.RentID, U.UserID, U.Name, U.LastName, R.VehicleID, R.RentDate, R.ReturnDate, R.Cost, R.Finished, R.Fine FROM Rents R inner join Users U on R.UserID=U.UserID WHERE U.UserID = {id}";
            DataTable dt = new DataTable();
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(showUserRentsData, connection);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Błąd podczas ładowania danych wypozyczeń użytkownika: {ex}");
                }
            }
            return dt;
        }
    }
}
