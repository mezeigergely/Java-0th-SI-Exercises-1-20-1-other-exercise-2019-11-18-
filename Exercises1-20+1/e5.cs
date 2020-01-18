using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises1_20_1
{
    class e5
    {
        public void Calc()
        {
            Menu menu = new Menu();
            Console.WriteLine();
            Console.WriteLine("CALCULATOR");
            Console.WriteLine("(press ENTER if you want to quit)");
            Console.WriteLine("---------------");
            while (true)
            {
                try
                {
                    Console.Write("Type a number 1: ");
                    double num1 = double.Parse(Console.ReadLine());
                    Console.Write("Type a number 2: ");
                    double num2 = double.Parse(Console.ReadLine());
                    double sum = num1 + num2;
                    double sub = num1 - num2;
                    double sub2 = num2 - num1;
                    double x = num1 * num2;
                    double div = num1 / num2;
                    double div2 = num2 / num1;
                    Console.WriteLine("Sum: " + sum);
                    Console.WriteLine("Sub: " + sub);
                    Console.WriteLine("Sub2: " + sub2);
                    Console.WriteLine("Multi: " + x);
                    Console.WriteLine("Div: " + div);
                    Console.WriteLine("Div2: " + div2);

                    Console.WriteLine();
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
