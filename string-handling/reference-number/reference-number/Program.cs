using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reference_number
{
    class Program
    {
        static void Main(string[] args)
        {
            void Generate()
            {
                Console.Write("Type reference data: ");
                string refnumber = Console.ReadLine().Replace(" ", "").Replace("-", "");

                int a = 1;
                int total = 0;

                for (int i = refnumber.Length - 1; i >= 0; i--)
                {
                    switch (a)
                    {
                        case 1:
                        {
                            total += int.Parse(refnumber[i].ToString()) * 7;
                            a++;
                            break;
                        }
                        case 2:
                        {
                            total += int.Parse(refnumber[i].ToString()) * 3;
                            a++;
                            break;
                        }
                        case 3:
                        {
                            total += int.Parse(refnumber[i].ToString()) * 1;
                            a = 1;
                            break;
                        }
                    }
                }

                int check = (total / 10 + 1) * 10 - total;

                Console.WriteLine($"Reference number: {Format(refnumber, check)}");
            }
            void Checker()
            {
                Console.Write("Reference number to check: ");
                string number = Console.ReadLine();

                string data = number.Remove(number.Length - 1);

                int a = 1;
                int total = 0;

                for (int i = data.Length - 1; i >= 0; i--)
                {
                    switch (a)
                    {
                        case 1:
                        {
                            total += int.Parse(data[i].ToString()) * 7;
                            a++;
                            break;
                        }
                        case 2:
                        {
                            total += int.Parse(data[i].ToString()) * 3;
                            a++;
                            break;
                        }
                        case 3:
                        {
                            total += int.Parse(data[i].ToString()) * 1;
                            a = 1;
                            break;
                        }
                    }
                }

                int check = (total / 10 + 1) * 10 - total; 

                string result = data + check;
                if (result == number)
                {
                    Console.WriteLine($"\nValid reference number.\n\nReference data: {data}\nCheck digit: {check}");
                }
                else
                {
                    Console.WriteLine("Invalid reference number.");
                }
            }

            string Format(string x, int y)
                    {
                        string output = string.Empty;

                        output = y + output;
                        for (int i = x.Length - 1; i >= 0; i--)
                        {
                            output = x[i] + output;

                            if (output.Length % 5 == 0)
                            {
                                output = " " + output;
                            }
                        }

                        return output.Trim();
                    }

            Generate();
            Checker();
            Console.ReadLine();       
        }
    }
}