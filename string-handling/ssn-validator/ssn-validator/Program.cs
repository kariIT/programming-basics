using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace ssn_validator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("SSN-VALIDATOR\n\nType social security number: ");
            string ssn = Console.ReadLine(); //ssn = social security number

            string bssn = ssn.Insert(2, "@").Insert(5, "@").Insert(8, "@").Insert(10, "@").Insert(14, "@"); //bssn = base social security number
            string[] split = bssn.Split('@', '@', '@', '@', '@');

            int dd = int.Parse(split[0]); //first 2 numbers of ssn entered
            int mm = int.Parse(split[1]); //3rd and 4th number
            int yy = int.Parse(split[2]); //5th and 6th number
            string divider = split[3];    //ssn divider (+, - or A)
            string individual = split[4]; //ssn individual numbers
            string checkdigit = split[5]; //ssn check digit

            void DateCheck(int x, int y, int a)
            {
                if (Enumerable.Range(1, 31).Contains(x))
                {
                    Console.Write(x.ToString("00"));
                }
                else
                {
                    End();
                }
                
                if (Enumerable.Range(1, 12).Contains(y))
                {
                    Console.Write(y.ToString("00"));
                }
                else
                {
                    End();
                }

                if (Enumerable.Range(0, 100).Contains(a))
                {
                    Console.Write(a.ToString("00"));
                }
                else
                {
                    End();
                }
            }//method to check that ssn date is valid

            DateCheck(dd, mm, yy); 
            string vssn = $"{split[3]}{split[4]}{split[5]} SSN date is valid. "; //vssn = verified social security number
            Console.WriteLine($"{vssn}");

            void Verify()
            {
                string verify = $"{dd.ToString("00")}{mm.ToString("00")}{yy.ToString("00")}{individual}";
                double remainder = double.Parse(verify) / 31;
                double simple = remainder - Math.Truncate(remainder);
                double c = simple * 31;
                int result = Convert.ToInt32(Math.Round(c));
                string compare = VerifyDigit(result).ToString();

                if (compare == checkdigit)
                {
                    Console.WriteLine($"SSN is valid. / {result}-{compare}");
                }
                else Console.WriteLine($"SSN not valid. / {result}-{compare}");

            }//method verifies ssn
            string VerifyDigit(int x)
            {
                if (x == 0) return "0";
                if (x == 1) return "1";
                if (x == 2) return "2";
                if (x == 3) return "3";
                if (x == 15) return "F";
                if (x == 25) return "T";
                else return "-1";
            }

            Verify();


            void Create()
            {

            }//method creates ssn and verifies it

            

            Console.ReadLine();

            

        }

        static void End()
        {
            Console.Clear();

            Console.WriteLine("Invalid SSN.\n\nPress <Enter> to continue..\n");
            Console.ReadLine();
            
            Console.Clear();
            Program.Main();
        }//used to exit/restart program more smoothly when invalid ssn is entered
    }
}
