using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2Delegate
{
    public delegate int myDelegate(int bal);
    public class bank
    {
        public event myDelegate LowBalance;
        public event myDelegate InsufficientBalance;
        public int bal;
        public int crAmt, dbAmt;

       // public int new_bal;
        public bank(int bal)
        {
            this.bal = bal;
        }
        public void check(int bal)
        {
            if (bal < 5000)
            {
                LowBalance();
                //Console.WriteLine("Low Balance");
            }
            else if (dbAmt > bal)
            {
                InsufficientBalance();
                //Console.WriteLine("Insufficient balance");
            }
            Console.WriteLine($"Your balance is {bal}");
        }

    }
    internal class Program
    {
        public static  void credit(int bal)
        {
            //Console.WriteLine("Enter Credit amount: ");
            //int crAmt = Convert.ToInt32(Console.ReadLine());
            //bal = bal + crAmt;
            Console.WriteLine($"Balance after credit: {bal}");
        }
        public static void debit(int bal)
        {
            //Console.WriteLine("Enter debit amount: ");
            //int dbAmt = Convert.ToInt32((Console.ReadLine()));
            //bal = bal - dbAmt;
            Console.WriteLine($"Balance after debit: {bal}");
        }
        static void Main(string[] args)
        {
            bank b = new bank(25000);

            b.LowBalance = new myDelegate(credit);

        }
    }
}
