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
            string ssn = Console.ReadLine();

            string bssn = ssn.Insert(2, "@").Insert(5, "@").Insert(8, "@").Replace("-", "").Replace("A",""); //bssn = base social security number
            string[] split = bssn.Split('@', '@','@');
            int dd = int.Parse(split[0]);
            int mm = int.Parse(split[1]);
            int yy = int.Parse(split[2]);

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
                    Console.Write(x.ToString("00"));
                }
                else
                {
                    End();
                }

                if (Enumerable.Range(0, 100).Contains(a))
                {
                    Console.Write(x.ToString("00"));
                }
                else
                {
                    End();
                }
            }//checks that ssn date is valid

            DateCheck(dd, mm, yy); 
            string vssn = $"-{split[3]}"; //vssn = verified social security number

            void Create()
            {

            }

            Console.WriteLine(vssn);

            Console.ReadLine();

        }

        static void End()
        {
            Console.Clear();

            Console.WriteLine("Invalid SSN.\n\nPress <Enter> to continue..\n");
            Console.ReadLine();
            
            Console.Clear();
            Program.Main();
        }
    }
}
