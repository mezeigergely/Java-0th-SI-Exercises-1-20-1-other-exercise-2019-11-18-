using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises1_20_1
{
    class e11
    {
        public void DivisibleBy9()
        {
            Menu menu = new Menu();
            Console.WriteLine();
            Console.WriteLine("DIVISIBLE by 9?");
            Console.WriteLine("(Press ENTER if you want to quit)");
            Console.WriteLine("---------------");
            while (true)
            {
                try
                {
                    Console.Write("Type a number: ");
                    int num = int.Parse(Console.ReadLine());
                    if (num % 9 == 0)
                    {
                        Console.WriteLine("Number is divisible by 9");
                    }
                    else
                    {
                        Console.WriteLine("Number is NOT divisible by 9");
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
