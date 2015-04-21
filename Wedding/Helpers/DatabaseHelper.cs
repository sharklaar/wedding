using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Wedding.Models;

namespace Wedding.Helpers
{
    public class DatabaseHelper
    {
        private string _connectionString;

        public DatabaseHelper()
        {

        }

        public void SubmitGuestDetails(GuestList guests)
        {
            _connectionString = ConfigurationManager.ConnectionStrings["WeddingDb"].ConnectionString;
            var connection = new SqlConnection(_connectionString);
            connection.Open();
            try
            {
                foreach (var guest in guests.Guests)
                {
                    var cmd = new SqlCommand("SubmitGuestDetails", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", guest.Id);
                    cmd.Parameters.AddWithValue("@AttendingCeremony", guest.AttendingCeremony);
                    cmd.Parameters.AddWithValue("@AttendingMeal", guest.AttendingMeal);
                    cmd.Parameters.AddWithValue("@AttendingReception", guest.AttendingReception);
                    cmd.Parameters.AddWithValue("@Starter", guest.Starter);
                    cmd.Parameters.AddWithValue("@Main", guest.Main);
                    cmd.Parameters.AddWithValue("@Dessert", guest.Dessert);

                    var reader = cmd.ExecuteNonQuery();                    
                }
            }
            finally
            {
                connection.Close();
            }
        }

        public List<Guest> GetGuestsWithUsername(string username)
        {
            var GuestList = new List<Guest>();

            _connectionString = ConfigurationManager.ConnectionStrings["WeddingDb"].ConnectionString;
            var connection = new SqlConnection(_connectionString);
            connection.Open();
            try
            {
                var cmd = new SqlCommand("GetGuests", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", username);

                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var guest = new Guest();

                    guest.Username = username;
                    guest.Id = int.Parse(reader["ID"].ToString());
                    guest.Name = reader["Name"].ToString();
                    guest.AttendingCeremony = GetBooleanFromBit(reader["AttendingCeremony"].ToString());
                    guest.AttendingMeal = GetBooleanFromBit(reader["AttendingMeal"].ToString());
                    guest.AttendingReception = GetBooleanFromBit(reader["AttendingReception"].ToString());
                    guest.CeremonyPermitted = GetBooleanFromBit(reader["CeremonyPermitted"].ToString());
                    guest.MealPermitted = GetBooleanFromBit(reader["MealPermitted"].ToString());
                    guest.ReceptionPermitted = GetBooleanFromBit(reader["ReceptionPermitted"].ToString());
                    guest.Dessert = reader["Dessert"].ToString();
                    guest.Main = reader["Main"].ToString();
                    guest.Starter = reader["Starter"].ToString();

                    GuestList.Add(guest);
                }

                return GuestList;
            }
            finally
            {
                connection.Close();
            }
        }

        private bool GetBooleanFromBit(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;

            if (input == "1")
                return true;

            if (input == "true")
                return true;

            if (input == "True")
                return true;

            return false;
        }
    }
}