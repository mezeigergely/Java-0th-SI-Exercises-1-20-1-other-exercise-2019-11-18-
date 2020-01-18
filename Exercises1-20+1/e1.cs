using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises1_20_1
{
    class e1
    {
        public void Circle()
        {
            Menu menu = new Menu();
            Console.WriteLine();
            Console.WriteLine("CIRCUMFERENCE OF A CIRCLE / AREA OF A CIRCLE\nSPHERE SURFACE / SPHERE VOLUME");
            Console.WriteLine("(press ENTER if you want to quit)");
            Console.WriteLine("---------------");
            while (true)
            {
                try
                {
                    Console.Write("Type a Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    double circumference = 2 * radius * 3.14;
                    double area = (radius * radius) * 3.14;
                    double surface = 4 * 3.14 * (radius * radius);
                    double volume = 4 / 3.0 * 3.14 * (radius * radius * radius);
                    Console.WriteLine("Circumference of a circle: " + circumference + " cm");
                    Console.WriteLine("Area of a circle: " + area + " cm2");
                    Console.WriteLine("Surface of Sphere: " + surface + " cm2");
                    Console.WriteLine("Volume of Sphere: " + volume + " cm3");
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
