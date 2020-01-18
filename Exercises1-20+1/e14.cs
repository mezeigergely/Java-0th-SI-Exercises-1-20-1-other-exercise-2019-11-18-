using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises1_20_1
{
    class e14
    {
        public void Profit()
        {
            Menu menu = new Menu();
            Console.WriteLine();
            Console.WriteLine("PROFIT OF YEAR");
            Console.WriteLine("(press ENTER if you want to quit)");
            Console.WriteLine("---------------");
            while (true)
            {
                try
                {
                    Console.Write("Profit: ");
                    int profit = int.Parse(Console.ReadLine());
                    Console.Write("Loss: ");
                    int loss = int.Parse(Console.ReadLine());
                    int total1 = profit - loss;
                    int total2 = loss - profit;
                    if (profit > loss)
                        Console.WriteLine("Company was profitable. Profit: " + total1.ToString("c"));
                    else if (profit < loss)
                        Console.WriteLine("Company was unprofitable. Loss: " + total2.ToString("c"));
                    else if (profit == loss)
                        Console.WriteLine("BEP");
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
