using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises1_20_1
{
    class e13
    {
        public void Month()
        {
            Menu menu = new Menu();
            Console.WriteLine();
            Console.WriteLine("Months");
            Console.WriteLine("(Press ENTER if you want to quit)");
            Console.WriteLine("---------------");
            while (true)
            {
                try
                {
                    Console.Write("Choose a month: ");
                    string month = Console.ReadLine();
                    if (month == "january" || month == "february" || month == "december")
                        Console.WriteLine("Winter");
                    else if (month == "march" || month == "april" || month == "may")
                        Console.WriteLine("Spring");
                    else if (month == "june" || month == "july" || month == "august")
                        Console.WriteLine("Summer");
                    else if (month == "september" || month == "october" || month == "november")
                        Console.WriteLine("Autumn");
                    else if (month == "q")
                        break;
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
