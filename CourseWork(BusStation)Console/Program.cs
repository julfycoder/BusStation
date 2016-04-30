using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CourseWork_BusStation_Console.Model.WorkingWithDatabase;
using CourseWork_BusStation_Console.Model.BusStationEntity;
using System.Data;
using System.Reflection;

namespace CourseWork_BusStation_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bus> buses = new List<Bus>();
            string busTable = "Bus";

            Database database = GetDataBase();

            Console.ReadLine();
        }
        static Database GetDataBase()
        {
            DatabaseBuilder builder = new MySqlDatabaseBuilder();
            builder.SetDatabaseName("mydb");
            builder.SetServerAddress("127.0.0.1");
            builder.SetPort(3306);
            builder.SetUserName("root");
            builder.SetPassword("");
            return builder.BuildDatabase();
        }
        
        static void DrawTable(DataTable myTable)
        {
            foreach (DataColumn column in myTable.Columns)
            {
                Console.Write(column.ColumnName + "\t\t");
            }
            Console.WriteLine();
            foreach (DataRow row in myTable.Rows)
            {
                foreach (DataColumn column in myTable.Columns) Console.Write(row[column] + "\t\t");
                Console.WriteLine();
            }
        }
    }
}
