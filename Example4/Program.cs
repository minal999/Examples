using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList emp1 = new ArrayList();
            emp1.Add(new Employee { Id = 1, Name = "Rahul", City = "Pune" });
            emp1.Add(new Employee { Id = 2, Name = "Rohan", City = "Mumbai" });
            ArrayList emp2 = new ArrayList();
            emp2.Add(new Employee { Id = 3, Name = "Rahul", City = "Pune" });
            emp2.Add(new Employee { Id = 4, Name = "Rohan", City = "Mumbai" });
            emp2.Add(new Employee { Id = 5, Name = "Kishor", City = "Nagpur" });
            ArrayList emp3 = new ArrayList() {
            new Employee { Id = 6, Name = "Dipali", City = "Pune" },
            new Employee { Id = 7, Name = "Minal", City = "Mumbai" },
            new Employee { Id = 8, Name = "Ashwini", City = "Nagpur" }
        };
            ArrayList dept1 = new ArrayList();
            dept1.Add(new Department { Id = 1, Name = "Tester", Salary = 25000, employees = emp1 });
            dept1.Add(new Department { Id = 2, Name = "Manager", Salary = 50000, employees = emp2 });
            dept1.Add(new Department { Id = 3, Name = "Developer", Salary = 45000, employees = emp3 });

            foreach (Department d in dept1)
            {
                Console.WriteLine($"\n{d.Id} {d.Name}  {d.Salary}");
                foreach (Employee e in d.employees)
                {
                    Console.WriteLine($"\t{e.Id} {e.Name}  {e.City}");
                }
            }
        }
    }
}
