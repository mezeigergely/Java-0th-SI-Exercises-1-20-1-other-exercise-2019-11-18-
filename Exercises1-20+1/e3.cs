using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises1_20_1
{
    class e3
    {
        public void Triangle()
        {
            Menu menu = new Menu();
            Console.WriteLine();
            Console.WriteLine("TRIANGLE");
            Console.WriteLine("(press ENTER if you want to quit)");
            Console.WriteLine("---------------");
            while (true)
            {
                try
                {
                    Console.Write("'A' side: ");
                    double a = int.Parse(Console.ReadLine());
                    Console.Write("'B' side: ");
                    double b = int.Parse(Console.ReadLine());
                    Console.Write("'C' side: ");
                    double c = int.Parse(Console.ReadLine());
                    if (a + b > c && a + c > b && b + c > a)
                    {
                        Console.WriteLine(true);
                    }
                    else
                    {
                        Console.WriteLine(false);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    break;
                }
            }
            menu.MenuDisplay();
        }
    }
}
