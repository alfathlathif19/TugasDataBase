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
    public class addData
    {
        public addData()
        {
            Database databaseObject = new Database();

            string query = "INSERT INTO Product ('Name') VALUES (@Name)";
            SQLiteCommand myCommand = new SQLiteCommand(query, databaseObject.myConnection);
            databaseObject.OpenConnection();
            myCommand.Parameters.AddWithValue("@Name", "Sprite");
            var result = myCommand.ExecuteNonQuery();
            databaseObject.CloseConnection();

            Console.WriteLine("Row added : {0}", result);
            Console.ReadKey();
        }
    }
}