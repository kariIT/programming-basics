using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vowel_counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a string: ");
            string str = Console.ReadLine();

            string vowels = "aeiouäö";
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (vowels.IndexOf(str.Substring(i, 1)) != -1)
                {
                    count++;
                }
            }
            Console.WriteLine($"String \"{str}\" contains {count} vowels.");
            Console.ReadLine();
        }
    }
}
