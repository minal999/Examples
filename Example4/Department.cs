using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public ArrayList employees { get; set; }

        //public Department(int id, string name, int salary, ArrayList employees)
        //{
        //    Id = id;
        //    Name = name;
        //    Salary = salary;
        //    this.employees = employees;
        //}
    }
}
