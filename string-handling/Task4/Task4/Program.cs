using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give string: ");
            string eki = Console.ReadLine();

            string onko = String.Empty;

            for (int i = 0; i < eki.Length; i++)
            {
                if (eki.Substring(i, 1) != eki.Substring(eki.Length - 1 - i, 1))
                {
                    onko = "is not";
                }
                else
                {
                    onko = "is";
                }
            }
            Console.WriteLine($"String \"{eki}\" {onko} a palindrome.");
            Console.ReadLine();
        }
    }
}
