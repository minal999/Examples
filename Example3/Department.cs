using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
         public Employee[] employees { get; set; }
    }
}
