using Ex2Delegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Ex2Delegate
{
    public delegate void myDelegate();
    public class bank
    {
        public event myDelegate LowBalance;
        public event myDelegate InsufficientBalance;
        public int bal { get; set; }
        public int crAmt, dbAmt;
        public bank(int bal)
        {
            this.bal = bal;
        }
        public void credit(int crAmt)
        {
            bal = bal + crAmt;
            Console.WriteLine($"Balance after credit: {bal}");
        }
        public void debit(int dbAmt)
        {
            if (bal < 5000)
            {
                LowBalance();

            }
            else if (dbAmt > bal)
            {
                InsufficientBalance();
                Console.WriteLine($"Your Balance : {bal}");
            }
            else
            {
                bal = bal - dbAmt;
                Console.WriteLine($"Balance after debit: {bal}");
            }
        }

        internal class Program
        {
            public static void lowBalance()
            {
                Console.WriteLine("Low Balance");
            }
            public static void insufficient()
            {
                Console.WriteLine("insufficient balance");
            }
            static void Main(string[] args)
            {
                bank b = new bank(5005);

                b.LowBalance += new myDelegate(lowBalance);
                b.InsufficientBalance += new myDelegate(insufficient);
                b.credit(400);
                b.debit(240000);
            }
        }
    }
}
