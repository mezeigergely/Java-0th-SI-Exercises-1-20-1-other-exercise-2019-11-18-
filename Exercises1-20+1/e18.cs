using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises1_20_1
{
    class e18
    {
        public void MeanTemperatureOfTheYear()
        {
            Menu menu = new Menu();
            Console.WriteLine();
            Console.WriteLine("MEAN TEMPERATURE OF THE YEAR");
            Console.WriteLine("(Press ENTER if you want to quit)");
            Console.WriteLine("---------------");
            while (true)
            {
                try
                {
                    Console.Write("Mean temperature of January?: ");
                    double january = double.Parse(Console.ReadLine());
                    Console.Write("Mean temperature of February?: ");
                    double february = double.Parse(Console.ReadLine());
                    Console.Write("Mean temperature of March?: ");
                    double march = double.Parse(Console.ReadLine());
                    Console.Write("Mean temperature of April?: ");
                    double april = double.Parse(Console.ReadLine());
                    Console.Write("Mean temperature of May?: ");
                    double may = double.Parse(Console.ReadLine());
                    Console.Write("Mean temperature of June?: ");
                    double june = double.Parse(Console.ReadLine());
                    Console.Write("Mean temperature of July?: ");
                    double july = double.Parse(Console.ReadLine());
                    Console.Write("Mean temperature of August?: ");
                    double august = double.Parse(Console.ReadLine());
                    Console.Write("Mean temperature of September?: ");
                    double september = double.Parse(Console.ReadLine());
                    Console.Write("Mean temperature of October?: ");
                    double october = double.Parse(Console.ReadLine());
                    Console.Write("Mean temperature of November?: ");
                    double november = double.Parse(Console.ReadLine());
                    Console.Write("Mean temperature of December?: ");
                    double december = double.Parse(Console.ReadLine());

                    double total = january + february + march + april + may + june + july + august + september + october + november + december;

                    Console.WriteLine("Mean temperature of the year: " + total / 12);
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
