using System;

namespace kertaustehtava_16_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give numbers: ");
            

            int x = 0;
            int y = 0;
            int i = 0;
            int sum = 0;

            do
            {
                string input = Console.ReadLine();
                if (i % 2 == 0)
                {
                    Console.Write("Give number: ");
                    x = int.Parse(input);
                    sum = sum + x;
                }
                else
                {
                    Console.Write("Give number: ");
                    y = int.Parse(input);
                    sum = sum + y;
                }

                i++;

            } while (x != y);

            Console.WriteLine($"Sum: {sum}");
            Console.ReadLine();
        }
    }
}
