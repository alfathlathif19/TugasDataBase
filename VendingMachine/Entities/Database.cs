using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace VendingMachine
{
    public class Database
    {
        public SQLiteConnection MyConnection { get; set; }

        public Database()
        {
            MyConnection = new SQLiteConnection("Data Source=databse.sqlite3");

            if (!File.Exists("./databse.sqlite3"))
            {
                SQLiteConnection.CreateFile("databse.sqlite3");
                Console.WriteLine("File dabase telah terbuat");
            }
        }

        public void OpenConnection()
        {
            if (MyConnection.State != System.Data.ConnectionState.Open)
            {
                MyConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (MyConnection.State != System.Data.ConnectionState.Closed)
            {
                MyConnection.Close();
            }
        }
    }
}
