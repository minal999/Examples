using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGeneric
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public int Price { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>();
            list1.Add(10);
            list1.Add(20);
            list1.Add(30);
            list1.Add(40);
            list1.Insert(2,50);
            list1.Remove(2);
            list1.Reverse(1, 4);
            list1.IndexOf(30);
       
            Console.WriteLine($"count is {list1.Count()}");
            Console.WriteLine($"Capacity is {list1.Capacity}");
            //list2.CopyTo(list1,2);
            //List<Product> list3 = new List<Product>();
            //list3.Add(new Product { Id = 1, Name = "Laptop", Price = 25000 });
            // or

            //List<Product> products = new List<Product>()
            //{
            //    new Product { Id = 1, Name = "Laptop", Price = 25000 },
            //    new Product { Id = 2, Name = "Laptop", Price = 25000 },
            //    new Product { Id = 3, Name = "Laptop", Price = 25000 },
            //};
            //foreach(Product p in products)
            //{
            //    Console.WriteLine($"{p.Id} {p.Name} {p.Price}");
            //}
            Console.WriteLine("Before sorting");
            foreach (int p in list1)
            {
                Console.WriteLine(p);
            }
            list1.Sort();
            Console.WriteLine("After sorting");
            foreach (int p in list1)
            {
                Console.WriteLine(p);
            }




        }
    }
}
