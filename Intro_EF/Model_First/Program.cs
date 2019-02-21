using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_First
{
    class Program
    {
        static void Main(string[] args)
        {
       
            var db = new UsersContainer();
            var department = new Department
            {
                Name = "Office"
            };
            var user = new User
            {
                FirstName = "Poghos",
                LastName = "Poghosyan",
                Email = "pog@gmail.am",
                Department =department
            };
            var admin = new Admin
            {
                FirstName = "Armen",
                LastName = "Adminyan",
                Email = "adm@mail.ru",
                Level = 80,
                Department =department
            };
            db.Users.Add(user);
            db.Users.Add(admin);
            db.SaveChanges();
            foreach (var item in db.Users)
            {
                
                Console.WriteLine(item.GetType());
            }
            Console.WriteLine(new string('-',20));
            var admin1 = db.Users.OfType<Admin>().First();
            Console.WriteLine(admin1.FirstName + ", level:" + admin1.Level);

            Console.WriteLine(department.Name);
            foreach (var item in department.Users)
            {
                Console.WriteLine(item.FirstName);
            }
            Console.WriteLine(new string('-', 20));

        }
        
    }
}
