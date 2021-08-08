using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteApp
{
    class DataAccess
    {
        public static void InitializeDatabase()
        {
            using (SqliteConnection db =
               new SqliteConnection("Filename=sqliteSample.db"))
            {
                db.Open();

                String tableCommand = "CREATE TABLE IF NOT " +
                    "EXISTS Customers (uid INTEGER PRIMARY KEY, " +
                    "first_Name CHARACTER(20) NULL, " +
                    "last_Name CHARACTER(20) NULL, " +
                    "email NCHAR(55) NULL)";

                SqliteCommand createTable = new SqliteCommand(tableCommand, db);

                createTable.ExecuteReader();
            }
        }

        public static void AddData(string inputFirstName, string inputLastName, string inputEmail)
        {
            using (SqliteConnection db =
                new SqliteConnection("Filename=sqliteSample.db"))
            {
                db.Open();

                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;

                insertCommand.CommandText = "INSERT INTO Customers VALUES (NULL, @FirstName, @LastName, @Email);";
                insertCommand.Parameters.AddWithValue("@FirstName", inputFirstName);
                insertCommand.Parameters.AddWithValue("@LastName", inputLastName);
                insertCommand.Parameters.AddWithValue("@Email", inputEmail);

                insertCommand.ExecuteReader();

                db.Close();
            }
        }
        public static List<String> GetData()
        {
            List<String> entries = new List<string>();

            using (SqliteConnection db =
                new SqliteConnection("Filename=sqliteSample.db"))
            {
                db.Open();

                SqliteCommand selectCommand = new SqliteCommand
                    ("SELECT email from Customers", db);

                SqliteDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    entries.Add(query.GetString(0));
                }

                db.Close();
            }

            return entries;
        }
    }
}
