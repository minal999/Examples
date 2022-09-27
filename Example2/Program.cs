using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList stud1 = new ArrayList();
            stud1.Add(new Student("Rahul", "Pune"));
            stud1.Add(new Student("Rohan", "Mumbai"));
            ArrayList stud2 = new ArrayList();
            stud2.Add(new Student("Rahul", "Pune"));
            stud2.Add(new Student("Rohan", "Mumbai"));
            stud2.Add(new Student("Kishor", "Nagpur"));
            ArrayList stud3 = new ArrayList();
            stud3.Add(new Student("Dipali", "Pune"));
            stud3.Add(new Student("Minal", "Mumbai"));
            stud3.Add(new Student("Ashwini", "Nagpur"));
            
            ArrayList courses=new ArrayList();
            courses.Add(new Course(1,"C#",50000,stud1));
            courses.Add(new Course(2, "Angular",20000, stud2));
            courses.Add(new Course(3, "MVC",45000, stud3));

            foreach(Course c in courses)
            {
                Console.WriteLine($"\n{c.Id} {c.Name}  {c.Fees}");
                foreach(Student s in c.students)
                {
                    Console.WriteLine($"\t{s.StudName}  {s.City}");
                }
            }
        }
    }
}
