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
            Console.WriteLine("\tSSN-VALIDATOR");

            //VERIFY SSN
            void Verification()
            { 
            Console.WriteLine("\n\nType social security number: ");
            string ssn = Console.ReadLine(); //ssn = social security number
            Console.Clear();

            string bssn = ssn.Insert(2, "@").Insert(5, "@").Insert(8, "@").Insert(10, "@").Insert(14, "@"); //bssn = base social security number
            string[] split = bssn.Split('@', '@', '@', '@', '@');

            int dd = int.Parse(split[0]); //first 2 numbers of ssn entered
            int mm = int.Parse(split[1]); //3rd and 4th number
            int yy = int.Parse(split[2]); //5th and 6th number
            string divider = split[3];    //ssn divider (+, - or A)
            string individual = split[4]; //ssn individual numbers
            string checkdigit = split[5]; //ssn check digit

            //DATE VERIFICATION
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
            Console.WriteLine($"{split[3]}{split[4]}{split[5]} \n\nSSN date is valid."); //vssn = verified social security number

            //SSN VERIFICATION
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
                    else
                    {
                        Console.WriteLine($"SSN not valid. / {result}-{compare}\n\nNOTICE: Program is case sensitive!");
                        Console.ReadLine();
                        End();
                    }
            }//method verifies ssn using the verication digit
            string VerifyDigit(int x)
            {
                if (x == 0) return "0";
                if (x == 1) return "1";
                if (x == 2) return "2";
                if (x == 3) return "3";
                if (x == 4) return "4";
                if (x == 5) return "5";
                if (x == 6) return "6";
                if (x == 7) return "7";
                if (x == 8) return "8";
                if (x == 9) return "9";
                if (x == 10) return "A";
                if (x == 11) return "B";
                if (x == 12) return "C";
                if (x == 13) return "D";
                if (x == 14) return "E";
                if (x == 15) return "F";
                if (x == 16) return "H";
                if (x == 17) return "J";
                if (x == 18) return "K";
                if (x == 19) return "L";
                if (x == 20) return "M";
                if (x == 21) return "N";
                if (x == 22) return "P";
                if (x == 23) return "R";
                if (x == 24) return "S";
                if (x == 25) return "T";
                if (x == 26) return "U";
                if (x == 27) return "V";
                if (x == 28) return "W";
                if (x == 29) return "X";
                if (x == 30) return "Y";
                else return "-1";
            }//gets the verification digit
            Verify();
        }//method asks for ssn and then verifies it

            //CREATE SSN
            string Create()
            {
                Random rnd = new Random();
                int d = rnd.Next(1, 31);
                string dd = d.ToString("00");

                int m = rnd.Next(1, 12);
                string mm = m.ToString("00");

                int y = rnd.Next(0, 99);
                string yy = y.ToString("00");

                string divider = "-";

                int i = rnd.Next(000, 999);
                string individual = i.ToString("000");

                int cd = rnd.Next(0, 30);
                string VerifyDigit(int x)
                {
                    if (x == 0) return "0";
                    if (x == 1) return "1";
                    if (x == 2) return "2";
                    if (x == 3) return "3";
                    if (x == 4) return "4";
                    if (x == 5) return "5";
                    if (x == 6) return "6";
                    if (x == 7) return "7";
                    if (x == 8) return "8";
                    if (x == 9) return "9";
                    if (x == 10) return "A";
                    if (x == 11) return "B";
                    if (x == 12) return "C";
                    if (x == 13) return "D";
                    if (x == 14) return "E";
                    if (x == 15) return "F";
                    if (x == 16) return "H";
                    if (x == 17) return "J";
                    if (x == 18) return "K";
                    if (x == 19) return "L";
                    if (x == 20) return "M";
                    if (x == 21) return "N";
                    if (x == 22) return "P";
                    if (x == 23) return "R";
                    if (x == 24) return "S";
                    if (x == 25) return "T";
                    if (x == 26) return "U";
                    if (x == 27) return "V";
                    if (x == 28) return "W";
                    if (x == 29) return "X";
                    if (x == 30) return "Y";
                    else return "-1";
                }
                string checkdigit = VerifyDigit(cd);

                Console.WriteLine($"\nSSN:{dd}{mm}{yy}{divider}{individual}{checkdigit}");
                return $"{dd}{mm}{yy}{divider}{individual}{checkdigit}";
            }//method creates invalid 20th century ssn :-D

            //Verification();
            //Create();

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
