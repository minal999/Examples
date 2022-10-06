using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String string1 = "Big black bug bit a big black dog on his big black nose";
            int count;

            //Converts the string into lowercase  
            string1 = string1.ToLower();

            //Split the string into words using built-in function  
            String[] words = string1.Split(' ');

            Console.WriteLine("Duplicate words in a given string : ");
            for (int i = 0; i < words.Length; i++)
            {
                count = 1;
                for (int j = i + 1; j < words.Length; j++)
                {
                    if (words[i].Equals(words[j]))
                    {
                        count++;
                        //Set words[j] to 0 to avoid printing visited word  
                        words[j] = "0";
                    }
                }

                //Displays the duplicate word if count is greater than 1  
                if (count > 1 && words[i] != "0")
                    Console.WriteLine(words[i]);
            }
        }
    }
}
