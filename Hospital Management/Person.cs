using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management
{
    public class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public double Weight { get; private set; }
        public string Address { get; private set; }
        public string PhoneNumber { get; private set; }

        public Person(string name, int age, double weight, string address, string phoneNumber)
        {
            this.Name = name;
            this.Age = age;
            this.Weight = weight;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
        }
    }
}
