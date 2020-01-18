using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises1_20_1
{
    class e6
    {
        public void TrueOrFalse()
        {
            Menu menu = new Menu();
            Console.WriteLine();
            Console.WriteLine("TRUE");
            Console.WriteLine("(press ENTER if you want to quit)");
            Console.WriteLine("---------------");
            while (true)
            {
                try
                {
                    Console.Write("Type 'true': ");
                    string userInput = Console.ReadLine();
                    if (userInput.Equals("true"))
                    {
                        Console.WriteLine("IGAZ");
                    }
                    else
                    {
                        break;
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
