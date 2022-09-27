using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4
{
    internal class Employee
    {
        public int Id;
        public string Name;
        public string City;
        public Employee(int id, string name, string city)
        {
            Id = id;
            Name = name;
            City = city;
        }
    }
}
