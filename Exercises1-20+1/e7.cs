using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises1_20_1
{
    class e7
    {
        public void Average()
        {
            Menu menu = new Menu();
            Console.WriteLine();
            Console.WriteLine("AVERAGE");
            Console.WriteLine("(Press ENTER if you want to quit)");
            Console.WriteLine("---------------");
            while (true)
            {
                try
                {
                    double num1;
                    double num2;
                    Console.WriteLine("Type 2 number!");
                    Console.Write("First: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Second: ");
                    num2 = double.Parse(Console.ReadLine());
                    double avg = (num1 + num2) / 2;
                    Console.WriteLine("Average = " + avg);

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
