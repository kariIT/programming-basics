using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ssn_validator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("SSN-VALIDATOR\n\nType social security number: ");
            string ssn = Console.ReadLine();

            string bssn = ssn.Insert(2, "@").Insert(5, "@").Insert(8, "@").Replace("-", "").Replace("A",""); //bssn = base social security number
            string[] split = bssn.Split('@', '@','@');
            int dd = int.Parse(split[0]);
            int mm = int.Parse(split[1]);
            int yy = int.Parse(split[2]);


            void CheckDD(int x)
            {
                if (Enumerable.Range(1, 32).Contains(x))
                {
                    Console.Write(x.ToString("00"));
                }
                else
                {
                    Console.WriteLine("Invalid SSN.(dd)");

                }
            }
            void CheckMM(int x)
            {
                if (Enumerable.Range(1, 13).Contains(x))
                {
                    Console.Write(x.ToString("00"));
                }
                else
                {
                    Console.WriteLine("Invalid SSN.(mm)");

                }
            }
            void CheckYY(int x)
            {
                if (Enumerable.Range(0, 100).Contains(x))
                {
                    Console.Write(x.ToString("00"));
                }
                else
                {
                    Console.WriteLine("Invalid SSN.(yy)");

                }
            }

            void Check(int x, int y, int a)
            {
                if (Enumerable.Range(1, 32).Contains(x))
                {
                    Console.Write(x.ToString("00"));
                }
                else
                {
                    Console.WriteLine("Invalid SSN.(yy)");

                }

                if (Enumerable.Range(1, 13).Contains(y))
                {
                    Console.Write(x.ToString("00"));
                }
                else
                {
                    Console.WriteLine("Invalid SSN.(yy)");

                }

                if (Enumerable.Range(0, 100).Contains(a))
                {
                    Console.Write(x.ToString("00"));
                }
                else
                {
                    Console.WriteLine("Invalid SSN.(yy)");

                }
            }

            //CheckDD(dd);
            //CheckMM(mm);
            //CheckYY(yy);

            Check(dd, mm, yy);


            string vssn = $"-{split[3]}"; //vssn = verified social security number

            Console.WriteLine(vssn);
            Console.ReadLine();

        }
    }
}
