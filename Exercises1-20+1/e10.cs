using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises1_20_1
{
    class e10
    {
        public void WieghtToHektoLiterDeciliter()
        {
            Menu menu = new Menu();
            Console.WriteLine();
            Console.WriteLine("MEASUREMENT CONVERSIONS");
            Console.WriteLine("(press ENTER if you want to quit)");
            Console.WriteLine("---------------");
            while (true)
            {
                try
                {
                    Console.Write("Type a weight in deciliter\n(1kg = 1l, 1kg = 10dl): "); ;
                    double userInput = double.Parse(Console.ReadLine());
                    double hectoliter = userInput / 1000;
                    double liter = userInput / 10;
                    double deciliter = userInput;

                    Console.WriteLine("{0} dl is {1} hl, {2} liter.",userInput,hectoliter,liter);
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
