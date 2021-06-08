using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;


namespace VendingMachine
{
    public class showData
    {
        public showData()
        {
            Database databaseObject = new();

            string query = "SELECT * FROM Product";
            SQLiteCommand myCommand = new(query, databaseObject.MyConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader result = myCommand.ExecuteReader();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    Console.WriteLine("{0}. {1}", result["id"], result["Name"]);
                }
            }
            databaseObject.CloseConnection();

            Console.ReadKey();
        }
    }
}