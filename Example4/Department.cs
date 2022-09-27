using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4
{
    internal class Department
    {
        public int Id;
        public string Name;
        public int Salary;
        public ArrayList employees;

        public Department(int id, string name, int salary, ArrayList employees)
        {
            Id = id;
            Name = name;
            Salary = salary;
            this.employees = employees;
        }
    }
}
