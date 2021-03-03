using System;
using System.Data.SQLite;
using System.IO;

namespace sqliteapp
{
    public class Database
    {
        public SQLiteConnection Connection { get; set; }
        private string database = "app.sqlite3";

        public Database()
        {
            Connection = new SQLiteConnection($"Data Source={database}");

            if (!File.Exists($"./{database}"))
            {
                SQLiteConnection.CreateFile(database);
                Console.WriteLine($"Database: {database} created...");
            }

        }

        public void OpenConnection()
        {
            if (Connection.State != System.Data.ConnectionState.Open)
            {
                Connection.Open();
                Console.WriteLine("Connection open");
            }
        }

        public void CloseConnection()
        {
            if (Connection.State != System.Data.ConnectionState.Closed)
            {
                Connection.Close();
                Console.WriteLine("Connection close");
            }
        }


    }
}