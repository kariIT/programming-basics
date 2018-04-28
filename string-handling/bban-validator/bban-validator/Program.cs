using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bban_validator
{
    class Program
    {
        static void Main(string[] args)
        {
                Bank nordea = new Bank(1, "Nordea");
                Bank nordea2 = new Bank(2, "Nordea");
                Bank handelsbanken = new Bank(31, "Handelsbanken");
                Bank seb = new Bank(33, "Skandinavia Enskilda Banken");
                Bank danskebank = new Bank(34, "Danske Bank");
                Bank tapiola = new Bank(36, "Tapiola Pankki");
                Bank dnbnor = new Bank(37, "DnB NOR Bank ASA");
                Bank swedbank = new Bank(38, "Swedbank");
                Bank spankki = new Bank(39, "S-Pankki");
                Bank aktia = new Bank(4, "Aktia Pankki, Säästöpankit (Sp) ja Paikallisosuuspankit (POP)");
                Bank op = new Bank(5, "Osuuspankit (OP), Helsingin OP Pankki ja Pohjola Pankki");
                Bank ålandsbanken = new Bank(6, "Ålandsbanken ÅAB");
                Bank sampo = new Bank(8, "Sampo Pankki");

            List<Bank> banks = new List<Bank>
            {
                nordea,
                nordea2,
                handelsbanken,
                seb,
                danskebank,
                tapiola,
                dnbnor,
                swedbank,
                spankki,
                aktia,
                op,
                ålandsbanken,
                sampo
            };

            Console.WriteLine("\nBBAN-VALIDATOR\n");
    
            string MachineFormat()
            {
                Console.Write("Give BBAN account number: ");
                string input = Console.ReadLine();

                try
                {
                    if (input.StartsWith("5"))
                    {
                        string bban = input.Replace("-", "").Insert(7, "@");
                        string[] split = bban.Split('@'); //splits the 'bban' string at '@'
                        string result = split[0].PadRight(14 - split[1].Length, '0') + split[1]; //adds zeroes until string length is 14 chars = converts it to machine language
                        //Console.WriteLine(result);
                        return result;
                    }
                    else if (input.StartsWith("4"))
                    {
                        string bban = input.Replace("-", "").Insert(7, "@");
                        string[] split = bban.Split('@'); //splits the 'bban' string at '@'
                        string result = split[0].PadRight(14 - split[1].Length, '0') + split[1]; //adds zeroes until string length is 14 chars = converts it to machine language
                        //Console.WriteLine(result);
                        return result;
                    }
                    else
                    {
                        string[] split = input.Split('-'); //splits the 'input' string from '-'
                        string bban = split[0].PadRight(14 - split[1].Length, '0') + split[1]; //adds zeroes until string length is 14 chars = converts it to machine language
                        //Console.WriteLine(bban);
                        return bban;
                    }
                }
                catch (Exception e)
                {
                    return $"\n{e.Message}";
                }
            }

            void Validator()
            {
                try
                {
                    string bban = MachineFormat();
                    int a = 1;
                    int total = 0;

                    for (int i = bban.Length - 1; i >= 0; i--)
                    {
                        switch (a)
                        {
                            case 1:
                            {
                                total += int.Parse(bban[i].ToString()) * 2;
                                a = 2;
                                break;
                            }
                            case 2:
                            {
                                total += int.Parse(bban[i].ToString()) * 1;
                                a = 1;
                                break;
                            }
                        }
                    }
                    int check = (total / 10 + 1) * 10 - total;
                    Console.WriteLine($"BBAN = {bban} {total} Check digit: {check}");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }  
            }

            Validator();
            Console.ReadLine();
            

        }
    }
}
