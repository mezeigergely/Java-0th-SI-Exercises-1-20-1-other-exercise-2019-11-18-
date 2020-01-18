using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises1_20_1
{
    class e12
    {
        public void HowManyNumChar()
        {
            Menu menu = new Menu();
            Console.WriteLine();
            Console.WriteLine("NUMBER OF DIGITS");
            Console.WriteLine("(Press 'q' if you want to quit)");
            Console.WriteLine("---------------");
            while (true)
            {
                try
                {
                    int counter = 0;
                    Console.Write("Type a number: ");
                    string num = Console.ReadLine();
                    for (int i = 0; i < num.Length; i++)
                    {
                        counter += 1;
                    }
                    Console.WriteLine(counter);
                    if (num == "q")
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
