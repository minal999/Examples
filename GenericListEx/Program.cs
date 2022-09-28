using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListEx
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public List<Employee> employees =new List<Employee> ();
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

            List<Department> dept1 = new List<Department>()
            {
                new Department
                {
                    Id=1,Name="Manager",Salary=75700,
                    employees ={
                    new Employee{EmpId=1,Name="Pooja",City="Pune",Gender="Female"},
                    new Employee{EmpId=2,Name="Laila",City="Delhi",Gender="Female"},
                    new Employee{EmpId=3,Name="Yash",City="Mumbai",Gender="Male"}
                    }
                },
                new Department
                {
                    Id=2,Name="Testing",Salary=25000,
                    employees={
                    new Employee{EmpId=1,Name="Ram",City="Pune",Gender="Male"},
                    new Employee{EmpId=2,Name="Rajesh",City="Delhi",Gender="Male"},
                    new Employee{EmpId=3,Name="Deepa",City="Mumbai",Gender="Female"}
                    } },
                new Department
                {
                    Id=3,Name="Developer",Salary=54000,
                    employees =
                    {
                    new Employee{EmpId=1,Name="Heena",City="Gujrat",Gender="Female"},
                    new Employee{EmpId=2,Name="Akash",City="Delhi",Gender="Male"},
                    }
                    },
            };

            foreach(Department dept in dept1)
            {
                Console.WriteLine($"{dept.Id} - {dept.Name} - {dept.Salary}" );
                foreach(Employee emp in dept.employees)
                {
                    Console.WriteLine($"\t{emp.EmpId} - {emp.Name} - {emp.City} - {emp.Gender}");
                }
            }
        }
    }
}
