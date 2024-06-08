using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_rental
{
    public class Person
    {
        private string id;
        private string name;
        private string address;
        private string phoneNum;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public string PhoneNum
        {
            get { return phoneNum; }
            set { phoneNum = value; }
        }
        public Person() { }
        public Person(string name, string address, string id, string phonenum)
        {
            this.name = name;
            this.address = address;
            this.id = id;
            this.phoneNum = phonenum;
        }
        public virtual void InfoPerson()
        {
            Console.WriteLine("-----Info------");
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Phone Number: " + phoneNum);
        }
    }
}
