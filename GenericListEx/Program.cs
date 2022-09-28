using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLisrEx
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public List<Employee> employees { get; set; }
    }

    public class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Gender { get; set; }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emp1 = new List<Employee>()
            {
                new Employee(){EmpId=1,Name="Pooja",City="Pune",Gender="Female"},
                new Employee(){EmpId=2,Name="Rohit",City="Mumbai",Gender="Male"}
            };
            List<Employee> emp2 = new List<Employee>()
            {
                new Employee(){EmpId=1,Name="Pranav",City="Kolkata",Gender="Male"},
                new Employee(){EmpId=2,Name="Ram",City="Pune",Gender="Male"},
                new Employee(){EmpId=3,Name="Tina",City="Delhi",Gender="Female"},
            };
            List<Employee> emp3 = new List<Employee>()
            {
                 new Employee(){EmpId=1,Name="Giya",City="Mumbai",Gender="Female"},
                new Employee(){EmpId=2,Name="Deepa",City="Pune",Gender="Female"},
                new Employee(){EmpId=3,Name="Amisha",City="Delhi",Gender="Female"},
            };

            List<Department> dept1 = new List<Department>()
            {
                new Department(){Id=1,Name="Manager",Salary=75700,employees=emp1},
                new Department(){Id=2,Name="Testing",Salary=25000,employees=emp2},
                new Department(){Id=3,Name="Developer",Salary=54000,employees=emp3},
            };

            foreach(Department dept in dept1)
            {
                Console.WriteLine($"{dept.Id}  {dept.Name}  {dept.Salary}" );
                foreach(Employee emp in dept.employees)
                {
                    Console.WriteLine($"\t{emp.EmpId}  {emp.Name}  {emp.City}  {emp.Gender}");
                }
            }
        }
    }
}
