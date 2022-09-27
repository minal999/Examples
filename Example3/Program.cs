using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] emp1 = new Employee[]
            {
                 new Employee { Id=1, Name = "Rahul", City = "Pune" },
                new Employee { Id=2,Name = "Rohan", City = "Mumbai" }
            };
            Employee[] emp2 = new Employee[]
            {
                 new Employee { Id=3, Name = "Rahul", City = "Pune" },
                new Employee { Id=4,Name = "Rohan", City = "Mumbai" },
                new Employee { Id=5,Name = "Kishor", City = "Nagpur" }
            };
            Employee[] emp3 = new Employee[]
           {
                 new Employee { Id=6,Name = "Dipali", City = "Pune" },
                new Employee { Id=7,Name = "Minal", City = "Mumbai" },
                new Employee { Id=8,Name = "Ashwini", City = "Nagpur" }
           };

            Department[] dept = new Department[]
            {
                 new Department{Id=1,Name="Developer",Salary=80000,employees=emp1 },
                 new Department{Id=2,Name="Tester",Salary=75000,employees=emp2 },
                 new Department{Id=3,Name="Manager",Salary=48000,employees=emp3 }
            };

            foreach (Department d in dept)
            {
                Console.WriteLine($"\n  Dept ID:{d.Id} Dept Name: {d.Name} Dept Salary: {d.Salary}");
                foreach (Employee e in d.employees)
                {
                    Console.WriteLine($"\t  Emp ID: {e.Id} Emp Name: {e.Name} Emp City: {e.City}");
                }
            }
        }
    }
}
