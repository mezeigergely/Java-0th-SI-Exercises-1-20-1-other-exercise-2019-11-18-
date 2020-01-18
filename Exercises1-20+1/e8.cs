using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises1_20_1
{
    class e8
    {
        public void Cuboid()
        {
            Menu menu = new Menu();
            Console.WriteLine();
            Console.WriteLine("CUBOID");
            Console.WriteLine("(Press ENTER if you want to quit)");
            Console.WriteLine("---------------");
            double a;
            double b;
            double c;
            while (true)
            {
                try
                {
                    Console.WriteLine("3 sides");
                    Console.Write("First side: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Second side: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Third side: ");
                    c = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Diagonals of Side: " + (Math.Sqrt((Math.Pow(a, 2) + Math.Pow(b, 2)))) + ", " +
                        (Math.Sqrt((Math.Pow(a, 2) + Math.Pow(c, 2)))) + ", " + (Math.Sqrt((Math.Pow(c, 2) + Math.Pow(b, 2)))));
                    Console.WriteLine("Diagonal of Cuboid: " + (Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2))));
                    Console.WriteLine("Volume of Cuboid: " + (a * b * c));
                    Console.WriteLine("Surface of Cuboid: " + (2 * (a * b + a * c + b * c)));
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
