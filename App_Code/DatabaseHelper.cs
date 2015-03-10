using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

/// <summary>
/// Summary description for DatabaseHelper
/// </summary>
public class DatabaseHelper
{
    private string _connectionString;

	public DatabaseHelper()
	{
        
	}

    public void GetGuestsWithUsername(string username)
    {
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
                var ceremonyPermitted = reader["CeremonyPermitted"];
            }
        }
        finally
        {
            connection.Close();
        }
    }
}