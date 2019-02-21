using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase_First
{
    class Program
    {
        static void Main(string[] args)
        {
            var contex = new ShopDBEntities();
            Console.WriteLine("Id  First Name    Last Name    Salary\n");
            foreach (var item in contex.People)
                           
                {
                    Console.WriteLine("{0,-2} {1,-12}  {2, -12}  {3}", item.EmployeeID, item.FName, item.LName, item.Salary);
                }
            
        }
    }
}
