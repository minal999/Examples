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

    public class AccountType
    {
        public string Name { get; set; }
        public List<Customer> customers = new List<Customer>();
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<AccountType> type1 = new List<AccountType>()
            {
                new AccountType
                {
                        Name = "Savings",
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
                new AccountType
                {
                    Name="Current",
                            customers =
                            {
                                new Customer
                                {
                                    CustName="Customer1",loans=
                                    {
                                        new Loan{LoanName="Car Loan"},
                                        new Loan{LoanName="Gold Loan"}
                                    }
                                },
                                new Customer
                                {
                                    CustName="Customer2",loans=
                                    {
                                        new Loan{LoanName="Education Loan"},
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
                                    CustName = "Customer4",
                                    loans =
                                    {
                                        new Loan{LoanName=""}
                                    }
                                    
                                },
                                new Customer
                                {
                                    CustName="Customer5",loans=
                                    {
                                        new Loan{LoanName="Home Loan"}
                                    }
                                }
                            }
                        }
                    };
    
            foreach(AccountType at in type1)
            {
                Console.WriteLine(at.Name);
                        foreach(Customer c in at.customers)
                        {
                            Console.WriteLine($"\n\t\t{c.CustName}");
                            foreach(Loan l in c.loans)
                            {
                                Console.WriteLine($"\t\t\t{l.LoanName}");
                                if(l.LoanName==String.Empty)
                        {
                            Console.WriteLine("\t\t\tNo Loan");
                        }
                            }
                        }
                }
            }

        }
    }

