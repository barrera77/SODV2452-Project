using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTask2.Data
{
    class UserDataService
    {
        private readonly string _connectionString = "Data Source=userprefs.db";

        public UserDataService()
        {
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();

            var tableCmd = connection.CreateCommand();
            tableCmd.CommandText = @"
                CREATE TABLE IF NOT EXISTS Users (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username TEXT NOT NULL
                );
            ";
            tableCmd.ExecuteNonQuery();
        }

        public string? GetLastSavedUsername()
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();

            var selectCmd = connection.CreateCommand();
            selectCmd.CommandText = "SELECT Username FROM Users ORDER BY Id DESC LIMIT 1";

            return selectCmd.ExecuteScalar()?.ToString();
        }

        public void SaveUsername(string name)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();

            var insertCmd = connection.CreateCommand();
            insertCmd.CommandText = "INSERT INTO Users (Username) VALUES ($name)";
            insertCmd.Parameters.AddWithValue("$name", name);
            insertCmd.ExecuteNonQuery();
        }

        //Get all saved usernames
        public List<string> GetAllSavedUsernames()
        {
            var names = new List<string>();
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();

            var selectCmd = connection.CreateCommand();
            selectCmd.CommandText = "SELECT Username FROM Users ORDER BY Id DESC";

            using var reader = selectCmd.ExecuteReader();
            while (reader.Read())
            {
                names.Add(reader.GetString(0));
            }

            return names;
        }
    }
}
