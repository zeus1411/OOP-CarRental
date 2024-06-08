using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_rental
{
    public class Customers:Person
    {
        public Customers() { }
        public Customers(string id, string name, string address, string phoneNum):base(name,address,id,phoneNum)
        {

        }
        public override void InfoPerson()
        {
            Console.WriteLine($"Name :{Name}");
            Console.WriteLine($"Address :{Address}");
            Console.WriteLine($"ID :{ID}");
            Console.WriteLine($"Phone Number :{PhoneNum}");
        }
    }
}
