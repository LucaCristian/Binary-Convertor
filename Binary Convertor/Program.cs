using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;

namespace Binary_Convertor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alege o optiune din meniu:");
            Console.WriteLine("\n1. Din baza 8 in baza 2");
            Console.WriteLine("2. Din baza 2 in baza 10");
            Console.WriteLine("3. Din baza 10 in baza 2");
            Console.WriteLine("4. Din baza 16 in baza 10");
            Console.WriteLine("5. Din baza 10 in baza 16");
            Console.WriteLine("6. Din baza 2 in baza 16");
            Console.WriteLine("7. Din baza 16 in baza 2");
            string fBase = "";
            string auxiliar = "";
            switch (Console.ReadLine())
            {
                case "1":
                    {
                        O1(fBase, auxiliar);
                        break;
                    }
                case "2":
                    {
                        O2(fBase, auxiliar);
                        break;
                    }
                case "3":
                    {
                        O3(fBase, auxiliar);
                        break;
                    }
                case "4":
                    {
                        O4(fBase, auxiliar);
                        break;
                    }
                case "5":
                    {
                        O5(fBase, auxiliar);
                        break;
                    }
                case "6":
                    {
                        O6(fBase, auxiliar);
                        break;
                    }
                case "7":
                    {
                        O7(fBase, auxiliar);
                        break;
                    }
            }
        }

        private static void O1(string fBase, string auxiliar)
        {
            Console.Write("Introduceti numarul pe care doriti sa-l convertiti: ");

            fBase = Console.ReadLine();

            for (int i = 0; i < fBase.Length; i++)
            {
                int t = int.Parse(fBase[i].ToString());
                switch (t)
                {
                    case 0:
                        {
                            auxiliar += "000";
                            break;
                        }
                    case 1:
                        {
                            auxiliar += "001";
                            break;
                        }
                    case 2:
                        {
                            auxiliar += "010";
                            break;
                        }
                    case 3:
                        {
                            auxiliar += "011";
                            break;
                        }
                    case 4:
                        {
                            auxiliar += "100";
                            break;
                        }
                    case 5:
                        {
                            auxiliar += "101";
                            break;
                        }
                    case 6:
                        {
                            auxiliar += "110";
                            break;
                        }
                    case 7:
                        {
                            auxiliar += "111";
                            break;
                        }
                }
            }
            Console.WriteLine($"Din baza 8 in baza 2: {auxiliar}");
            Console.ReadKey();
        }
        private static void O2(string fBase, string auxiliar)
        {
            Console.Write("Introduceti numarul pe care doriti sa-l convertiti: ");

            fBase = Console.ReadLine();

            int rezultat = 0;
            for (int i = 0; i < fBase.Length; i++)
            {

                int t = int.Parse(fBase[i].ToString());


                int power = 1;

                for (int j = i; j < fBase.Length - 1; j++)

                    power *= 2;


                rezultat += t * power;
            }
            Console.WriteLine($"Din baza 2 in baza 10: {rezultat}");
            Console.ReadKey();
        }
        private static void O3(string fBase, string auxiliar)
        {
            Console.Write("Introduceti numarul pe care doriti sa-l convertiti: ");
            fBase = Console.ReadLine();
            string binary = Convert.ToString(int.Parse(fBase), 2);
            Console.WriteLine($"Din baza 10 in baza 2: {binary}");
            Console.ReadKey();
        }
        private static void O4(string fBase, string auxiliar)
        {
            Console.Write("Introduceti numarul pe care doriti sa-l convertiti: ");
            fBase = Console.ReadLine();

            int result = 0;
            for (int i = 0; i < fBase.Length; i++)
            {

                int t = int.Parse(fBase[i].ToString(), System.Globalization.NumberStyles.HexNumber);


                int power = 1;

                for (int j = i; j < fBase.Length - 1; j++)

                    power *= 16;

                result += t * power;
            }
            Console.WriteLine($"Din baza 16 in baza 10: {result}");
            Console.ReadKey();
        }
        private static void O5(string fBase, string auxiliar)
        {
            Console.Write("Introduceti numarul pe care doriti sa-l convertiti: ");
            fBase = Console.ReadLine();
            string binary = Convert.ToString(int.Parse(fBase), 16);
            Console.WriteLine($"Din baza 10 in baza 16: {binary}");
            Console.ReadKey();
        }
        private static void O6(string fBase, string auxiliar)
        {
            Console.Write("Introduceti numarul pe care doriti sa-l convertiti: ");
            fBase = Console.ReadLine();
            int result = 0;
            for (int i = 0; i < fBase.Length; i++)
            {
                int t = int.Parse(fBase[i].ToString());
                int power = 1;

                for (int j = i; j < fBase.Length - 1; j++)
                    power *= 2;
                result += t * power;
            }
            string binary = Convert.ToString(result, 16);
            Console.WriteLine($"Din baza 2 in baza 16: {binary}");
            Console.ReadKey();
        }
        private static void O7(string fBase, string auxiliar)
        {
            Console.Write("Introduceti numarul pe care doriti sa-l convertiti: ");

            fBase = Console.ReadLine();

            for (int i = 0; i < fBase.Length; i++)
            {

                char t = fBase[i];
                switch (t)
                {
                    case '0':
                        {
                            auxiliar += "0000";


                            break;
                        }
                    case '1':
                        {

                            auxiliar += "0001";
                            break;
                        }
                    case '2':
                        {
                            auxiliar += "0010";
                            break;
                        }
                    case '3':
                        {
                            auxiliar += "0011";
                            break;
                        }
                    case '4':
                        {
                            auxiliar += "0100";
                            break;
                        }
                    case '5':
                        {
                            auxiliar += "0101";
                            break;
                        }
                    case '6':
                        {
                            auxiliar += "0110";
                            break;
                        }
                    case '7':
                        {
                            auxiliar += "0111";
                            break;
                        }
                    case '8':
                        {
                            auxiliar += "1000";
                            break;
                        }
                    case '9':
                        {
                            auxiliar += "1001";
                            break;
                        }
                    case 'A':
                    case 'a':
                        {
                            auxiliar += "1010";
                            break;
                        }
                    case 'B':
                    case 'b':
                        {
                            auxiliar += "1011";
                            break;
                        }
                    case 'C':
                    case 'c':
                        {
                            auxiliar += "1100";
                            break;
                        }
                    case 'D':
                    case 'd':
                        {
                            auxiliar += "1101";
                            break;
                        }
                    case 'E':
                    case 'e':
                        {
                            auxiliar += "1110";
                            break;
                        }
                    case 'F':
                    case 'f':
                        {
                            auxiliar += "1111";
                            break;
                        }


                }


            }
            Console.WriteLine($"Din baza 16 in baza 2: {auxiliar}");
            Console.ReadKey();
        }
    }
}
