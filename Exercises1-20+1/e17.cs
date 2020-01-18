using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises1_20_1
{
    class e17
    {
        public void Month2()
        {
            Menu menu = new Menu();
            Console.WriteLine();
            Console.WriteLine("Months 2");
            Console.WriteLine("(Press ENTER if you want to quit)");
            Console.WriteLine("---------------");
            while (true)
            {
                try
                {
                    Console.WriteLine("1. January");
                    Console.WriteLine("2. February");
                    Console.WriteLine("3. March");
                    Console.WriteLine("4. April");
                    Console.WriteLine("5. May");
                    Console.WriteLine("6. June");
                    Console.WriteLine("7. July");
                    Console.WriteLine("8. August");
                    Console.WriteLine("9. Septembre");
                    Console.WriteLine("10. October");
                    Console.WriteLine("11. November");
                    Console.WriteLine("12. December");
                    Console.WriteLine("Which month do you want to choose? (number)");

                    int answer = int.Parse(Console.ReadLine());

                    if (answer == 1 || answer == 2 || answer == 12)
                        Console.WriteLine("Winter");
                    else if (answer == 3 || answer == 4 || answer == 5)
                        Console.WriteLine("Spring");
                    else if (answer == 6 || answer == 7 || answer == 8)
                        Console.WriteLine("Summer");
                    else
                        Console.WriteLine("Autumn");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    break;
                }
            }
            Console.WriteLine();
            menu.MenuDisplay();
        }
    }
}
