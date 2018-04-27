using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give a string: ");
            string str = Console.ReadLine();

            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str.Substring(i, 1).ToUpper()== "A")
                {
                    count++;
                }
            }
            Console.WriteLine($"String \"{str}\" has {count} \"A\" letters.");

            Console.ReadLine();
        }
    }
}
