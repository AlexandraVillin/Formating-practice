using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Formatiranje
{
    class Program
    {
        static string chageCase(string text, int i)
        {
            string txt;

            switch (i)
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
            int x;
            Console.WriteLine("Choose action:\n1. Insert text\n2. Change format\n0. Exit");
            do
            {
                x = int.Parse(Console.ReadLine());
                if (x == 1)
                {
                    text = Console.ReadLine();
                }
                else if (x == 2)
                {
                    int i;
                    do
                    {
                        Console.WriteLine("Choose action:\n1. Lower-case letters\n2. Upper-case letters\n3. Capital letters\n0. Go back");
                        i = int.Parse(Console.ReadLine());
                        if (i == 1 || i == 2 || i == 3)
                        {
                            if (text == null)
                            {
                                Console.WriteLine("Text does not exist");
                                continue;
                            }
                            else
                                Console.WriteLine(chageCase(text, i));
                        }
                        else if (i == 0)
                            continue;

                    } while (i != 0);


                }
                else
                    continue;

            } while (x != 0);


        }
    }
}