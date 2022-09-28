using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList2
{
    public class Loan
    {
        public string LoanName { get; set; }
    }
    public class Customer
    {
        public string CustName { get; set; }
        public List<Loan> loans = new List<Loan>();
    }

    public class Account
    {
        public string AccName { get; set; }
        public List<Customer> customers = new List<Customer>();
    }

    public class AccountType
    {
        public string Name { get; set; }
        public List<Account> accounts = new List<Account>();
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<AccountType> type1 = new List<AccountType>()
            {
                new AccountType
                {
                    Name="AccountTypes",accounts ={
                    new Account
                    {
                        AccName = "Savings",
                        customers =
                        {
                            new Customer
                            {
                                CustName = "Customer1",
                                loans =
                                {
                                    new Loan{LoanName="Home Loan"},
                                    new Loan{LoanName="Car Loan"}
                                }

                            },
                            new Customer
                            {
                                CustName = "Customer2",
                                loans =
                                {
                                    new Loan{LoanName="Home Loan"},
                                }
                            },
                            new Customer
                            {
                                CustName = "Customer3",
                                loans =
                                {
                                    new Loan{LoanName="Education Loan"},
                                }
                            }
                        }
                    },
                        new Account
                        {
                            AccName="Current",
                            customers =
                            {
                                new Customer
                                {
                                    CustName="Customer1",loans=
                                    {
                                        new Loan{LoanName="Car Loan"}
                                    }
                                },
                                new Customer
                                {
                                    CustName="Customer2",loans=
                                    {
                                        new Loan{LoanName="Home Loan"},
                                        new Loan{LoanName="Personal Loan"}
                                    }
                                },
                                new Customer
                                {
                                    CustName="Customer3",loans=
                                    {
                                        new Loan{LoanName="Car Loan"}
                                    }
                                },
                                new Customer
                                {
                                    CustName="Customer4",loans=
                                    {
                                        new Loan{LoanName="No Loan"}
                                    }
                                }
                            }
                        }
                    }
                }
            };
            foreach(AccountType at in type1)
            {
                Console.WriteLine(at.Name);
                foreach(Account a in at.accounts)
                {
                    Console.WriteLine($"\t{a.AccName}");
                        foreach(Customer c in a.customers)
                        {
                            Console.WriteLine($"\t\t{c.CustName}");
                            foreach(Loan l in c.loans)
                            {
                                Console.WriteLine($"\t\t\t{l.LoanName}");
                            }
                        }
                }
            }

        }
    }
}
