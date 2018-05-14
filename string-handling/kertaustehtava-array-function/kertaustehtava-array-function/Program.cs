using System;
using System.Security.Cryptography.X509Certificates;

namespace kertaustehtava_array_function
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new[] {2, 5, 10, 7, 3};

            for (int i = 0; i < numbers.Length; i++)
            {
                string format = Format(numbers[i]);
                Console.WriteLine($"{format}");
            }

            Console.ReadLine();
        }

        static string Format(int x)
        {
            string result = String.Empty;
            for (int i = 0; i < x; i++)
            {
                result += "*";
            }

            return result;
        }
    }
}
