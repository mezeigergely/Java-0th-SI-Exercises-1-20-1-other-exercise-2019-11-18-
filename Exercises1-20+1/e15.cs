using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises1_20_1
{
    class e15
    {
        public void LanguageTest()
        {
            Menu menu = new Menu();
            Console.WriteLine();
            Console.WriteLine("LANGUAGE TEST");
            Console.WriteLine("(Press 'q' if you want to quit)");
            Console.WriteLine("---------------");
            while (true)
            {
                try
                {
                    Console.WriteLine("Do you speak in hungarian? If yes, please answer in hungarian, if no, please write 'no'!");
                    string answer = Console.ReadLine();
                    if (answer == "igen")
                    {
                        Console.WriteLine("Szia!");
                    }
                    else if (answer == "no")
                        Console.WriteLine("¦");
                    else if (answer == "q")
                        break;

                    Console.WriteLine("Do you speak in english? If yes, please answer in english, if no, please write 'no'!");
                    string answer2 = Console.ReadLine();
                    if (answer2 == "yes")
                    {
                        Console.WriteLine("Hi!");
                    }
                    else if (answer2 == "no")
                        Console.WriteLine("¦");
                    else if (answer2 == "q")
                        break;

                    Console.WriteLine("Do you speak in french? If yes, please answer in french, if no, please write 'no'!");
                    string answer3 = Console.ReadLine();
                    if (answer3 == "oui")
                    {
                        Console.WriteLine("Salut!");
                    }
                    else if (answer3 == "no")
                        Console.WriteLine("¦");
                    else if (answer3 == "q")
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
