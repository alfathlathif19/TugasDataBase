using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;


namespace VendingMachine
{
    //Kelas ini hanya digunakan untuk menginput data baru ke database
    public class AddData
    {
        public AddData()
        {
            Database databaseObject = new();

            string query = "INSERT INTO Product ('Name') VALUES (@Name)";
            SQLiteCommand myCommand = new(query, databaseObject.MyConnection);
            databaseObject.OpenConnection();
            myCommand.Parameters.AddWithValue("@Name", "Sprite");
            int result = myCommand.ExecuteNonQuery();
            databaseObject.CloseConnection();

            Console.WriteLine("Row added : {0}", result);
            Console.ReadKey();
        }
    }
}