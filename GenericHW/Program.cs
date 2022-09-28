using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stack<int> stack = new Stack<int>();
            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30);
            //stack.Push(40);
            //stack.Pop();
            //Console.WriteLine("Peek od stack is "+stack.Peek());
            //foreach(int i in stack)
            //{
            //    Console.WriteLine(i);
            //}


            //Queue<string> queue=new Queue<string>();
            //queue.Enqueue("Kajol");
            //queue.Enqueue("Naina");
            //queue.Enqueue("Laila");

            //queue.Dequeue();
            //Console.WriteLine("Peek of queue is " + queue.Peek());
            //foreach (string item in queue)
            //{
            //    Console.WriteLine(item);
            //}


            Dictionary<int, string> dic = new Dictionary<int, string>() {
                {91,"IND" },
                {1,"USA" },
                {63,"AUS" },
                {333,"FR" }
            };
            foreach(KeyValuePair<int, string> a in dic)
            {
                Console.WriteLine($"{a.Key} {a.Value}");
            }
        }
    }
}
