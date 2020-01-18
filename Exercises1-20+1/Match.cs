using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises1_20_1
{
    class Match
    {
        public void PairMatch()
        {
            Menu menu = new Menu();
            Console.WriteLine();
            Console.WriteLine("MATCH?");
            Console.WriteLine("(Press ENTER if you want to quit)");
            Console.WriteLine("---------------");
            while (true)
            {
                try
                {
                    Console.Write("Person #1 name: ");
                    string p1Name = Console.ReadLine();
                    Console.Write("Person #1 height: ");
                    int p1Height = int.Parse(Console.ReadLine());
                    Console.Write("Person #1 age: ");
                    int p1Age = int.Parse(Console.ReadLine());

                    Console.Write("Person #2 name: ");
                    string p2Name = Console.ReadLine();
                    Console.Write("Person #2 height: ");
                    int p2Height = int.Parse(Console.ReadLine());
                    Console.Write("Person #2 age: ");
                    int p2Age = int.Parse(Console.ReadLine());

                    Person p1 = new Person(p1Name, p1Height, p1Age);
                    Console.WriteLine(p1.name);
                    Console.WriteLine(p1.height);
                    Console.WriteLine(p1.age);

                    Person p2 = new Person(p2Name, p2Height, p2Age);
                    Console.WriteLine(p2.name);
                    Console.WriteLine(p2.height);
                    Console.WriteLine(p2.age);


                    if ((p1Age < 14 && p2Age > 19) || (p2Age < 14 && p1Age > 19))
                    {
                        Console.WriteLine("Sorry...It's not gonna work!");
                    }
                    else
                    {
                        Console.WriteLine("Ok! Have fun!");
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
