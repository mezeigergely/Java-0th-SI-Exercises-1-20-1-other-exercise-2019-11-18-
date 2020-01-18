using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises1_20_1
{
    class e2
    {
        public void DescOrder()
        {
            Menu menu = new Menu();
            Console.WriteLine();
            Console.WriteLine("NUMBERS IN DESCENDING ORDER");
            Console.WriteLine("(press ENTER if you want to quit)");
            Console.WriteLine("---------------");
            int counter = 0;
            List<int> numbers = new List<int>();
            while (true)
            {
                try
                {
                    for (int i = 0; i < 3; i++)
                    {
                        counter += 1;
                        Console.Write("Type a number #{0}: ", counter);
                        int num = int.Parse(Console.ReadLine());
                        numbers.Add(num);
                    }
                    numbers.Sort();
                    numbers.Reverse();
                    Console.Write("Numbers in descending order: ");
                    foreach (var item in numbers)
                    {
                        Console.Write(item + ", ");
                    }
                    break;
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
