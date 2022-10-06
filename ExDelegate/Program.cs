using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExDelegate
{
    public delegate string MyDelegate(string name);

    public class UpperLower
        {
        public string upper(string name)
        {
            string upper=name.ToUpper();
            return "String in UpperCase : "+upper;
        }
        public string lower(string name)
        {
            string lower = name.ToLower();
            return "String in LowerCase : "+lower;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            UpperLower ul=new UpperLower();
            MyDelegate myDelegate = new MyDelegate(ul.upper); 
            myDelegate += new MyDelegate(ul.lower);

            Delegate[] list = myDelegate.GetInvocationList();
            foreach (Delegate d in list)
            {
                Console.WriteLine(d.DynamicInvoke("Welcome to visual studio"));
            }
        }
    }
}
