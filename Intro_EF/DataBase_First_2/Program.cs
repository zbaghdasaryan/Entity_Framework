using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data;
using System.Data.SqlClient;
using DataBase_First_2.Properties;

namespace DataBase_First_2
{
    class Program
    {
        static List<Customer> GetCustomersEF()
        {
            var context = new DbEntitiesContext();
            var customers = context.Customers.ToList();
            return customers;         
        }

        static void Main(string[] args)
        {
            {
                var customers = GetCustomersEF();

               
                foreach (var item in customers)
                {
                    Console.WriteLine("{0,-2} {1,-12}  {2, -12}  {3}", item.CustomerNo, item.FName, item.LName, item.Phone);
                }

                //var contex = new DbEntitiesContext();
                //Console.WriteLine("Id  First Name    Last Name    Salary\n");
                //foreach (var item in contex.Customers)
                //{
                //    Console.WriteLine("{0,-2} {1,-12}  {2, -12}  {3}", item.CustomerNo, item.FName, item.LName, item.Phone);
                //}
            }



            //using (IDbConnection connection = new SqlConnection(Settings.Default.DbConnect))
            //{
            //    IDbCommand command = new SqlCommand("select*from Customers");
            //    command.Connection = connection;
            //    connection.Open();
            //    IDataReader reader = command.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        Console.WriteLine("Id:{0,-6} FName {1}", reader.GetInt32(0), reader.GetString(1));
            //    }
            //}
        }
    }
}
