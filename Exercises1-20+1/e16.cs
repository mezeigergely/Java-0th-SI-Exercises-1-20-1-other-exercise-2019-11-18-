using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises1_20_1
{
    class e16
    {
        public void Password()
        {
            Menu menu = new Menu();
            Console.WriteLine();
            Console.WriteLine("PASSWORD");
            Console.WriteLine("---------------");
            string password = "abc";
            string userinput = null;
            int counter = 1;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Password #{0}/5? ", counter);
                userinput = Console.ReadLine();
                counter += 1;
                if (userinput == password)
                {
                    Console.WriteLine("Correct");
                    break;
                }
                else if (userinput != password)
                {
                    Console.WriteLine("Wrong password");
                    if (counter == 6)
                    {
                        Console.WriteLine("Closed");
                        break;

                    }
                }
            }
            menu.MenuDisplay();
        }
    }
}
