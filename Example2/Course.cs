using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    internal class Course
    {
        public int Id;
        public string Name;
        public int Fees;
        public ArrayList students;

        public Course(int id, string name,int fees, ArrayList students)
        {
            Id = id;
            Name = name;
            Fees = fees;
            this.students = students;
        }
    }
}
