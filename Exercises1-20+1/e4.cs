using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises1_20_1
{
    class e4
    {
        public void NorP()
        {
            Menu menu = new Menu();
            Console.WriteLine();
            Console.WriteLine("NEGATIVE or POSITIVE");
            Console.WriteLine("(press ENTER if you want to quit)");
            Console.WriteLine("---------------");
            while (true)
            {
                try
                {
                    Console.Write("Type a number: ");
                    int num = int.Parse(Console.ReadLine());
                    if (num > 0)
                    {
                        Console.WriteLine("Positive");
                    }
                    else if (num == 0)
                    {
                        Console.WriteLine("Zero");
                    }
                    else
                    {
                        Console.WriteLine("Negative");
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
