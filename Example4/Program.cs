using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList emp1=new ArrayList();
            emp1.Add(new Employee(1,"Rahul", "Pune"));
            emp1.Add(new Employee(2,"Rohan", "Mumbai"));
            ArrayList emp2 = new ArrayList();
            emp2.Add(new Employee(3, "Rahul", "Pune"));
            emp2.Add(new Employee(4, "Rohan", "Mumbai"));
            emp2.Add(new Employee(5,"Kishor", "Nagpur"));
            ArrayList emp3 = new ArrayList();
            emp3.Add(new Employee(6,"Dipali", "Pune"));
            emp3.Add(new Employee(7, "Minal", "Mumbai"));
            emp3.Add(new Employee(8, "Ashwini", "Nagpur"));

            ArrayList dept1 = new ArrayList();
            dept1.Add(new Department(1, "Tester", 25000, emp1));
            dept1.Add(new Department(2, "Manager", 50000, emp2));
            dept1.Add(new Department(3, "Developer", 45000, emp3));

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
