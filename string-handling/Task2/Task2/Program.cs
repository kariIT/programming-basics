using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string matti = "Hello world!";
            var replace = matti.Replace("e", "@");
            var replace2 = matti.Replace("l", "B");

            var replace3 = replace.Replace("l", " C ");

            Console.WriteLine($"{matti}\n{replace}\n{replace2}\n{replace3}");

            Console.ReadLine();

        }
    }
}
