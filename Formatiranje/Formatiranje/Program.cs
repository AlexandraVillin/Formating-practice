using System;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security;
using System.Globalization;

namespace uppercase_04._10._2020
{
    class Program
    {
        static string chageCase(string text, int b)
        {
            string txt;

            switch (b)
            {
                case 1:
                    txt = text.ToLower();
                    break;
                case 2:
                    txt = text.ToUpper();
                    break;
                case 3:
                    txt = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text.ToLower());
                    break;
                default:
                    return null;
            }
            return txt;
        }
        static void Main(string[] args)
        {
            string text = null;
            int a;
            Console.WriteLine("Izaberite radnju:\n1. Unesi tekst\n2. Promeni format\n0. Izadji");
            do
            {
                a = int.Parse(Console.ReadLine());
                if (a == 1)
                {
                    text = Console.ReadLine();
                }
                else if (a == 2)
                {
                    int b;
                    do
                    {
                        Console.WriteLine("Izaberite radnju:\n1. Mala slova\n2. Velika slova\n3. Prva slova velika\n0. Nazad");
                        b = int.Parse(Console.ReadLine());
                        if (b == 1 || b == 2 || b == 3)
                        {
                            if (text == null)
                            {
                                Console.WriteLine("Tekst ne postoji");
                                continue;
                            }
                            else
                                Console.WriteLine(chageCase(text, b));
                        }
                        else if (b == 0)
                            continue;

                    } while (b != 0);


                }
                else
                    continue;

            } while (a != 0);


        }
    }
}