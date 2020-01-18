using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises1_20_1
{
    class e19
    {
        public void CoffeeMachine()
        {
            Menu menu = new Menu();
            Console.WriteLine();
            Console.WriteLine("COFFEE MACHINE");
            Console.WriteLine("(Press ENTER if you want to quit)");
            Console.WriteLine("---------------");
            Console.WriteLine("MENU\n'Standard Coffee':\t200Ft\n'Cappuccino':\t\t+50Ft\n'Double':\t\t+20Ft");
            int standardCoffee = 200;
            int cappuccino = 50;
            int doubleCoffee = 20;
            int glass = 10;
            int total = 0;
            int quantity;
            string userInput;
            while (true)
            {
                try
                {
                    Console.Write("Quantity of Standard Coffee: ");
                    int standardCoffeeQuantity = int.Parse(Console.ReadLine());
                    int standardCoffeprice = standardCoffeeQuantity * standardCoffee;
                    Console.Write("Quantity of Cappuccino: ");
                    int cappuccinoQuantity = int.Parse(Console.ReadLine());
                    int cappuccinoPrice = (standardCoffee + cappuccino) * cappuccinoQuantity;
                    Console.Write("Quantity of Double Coffee: ");
                    int doubleQuantity = int.Parse(Console.ReadLine());
                    int doublePrice = (standardCoffee + doubleCoffee) * doubleQuantity;
                    Console.Write("With or without glass ('y' or 'n')? ");
                    string answer = Console.ReadLine();
                    if (answer == "y")
                    {
                        total = standardCoffeprice + cappuccinoPrice + doublePrice;
                        Console.WriteLine("Total: {0}", total.ToString("c"));
                    }
                    else if (answer == "n")
                    {
                        total = standardCoffeprice + cappuccinoPrice + doublePrice - glass;
                        Console.WriteLine("Total: {0}", total.ToString("c"));
                    }
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
