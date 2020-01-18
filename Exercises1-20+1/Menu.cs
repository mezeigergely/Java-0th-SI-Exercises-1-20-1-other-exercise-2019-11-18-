using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises1_20_1
{
    class Menu
    {
        public void MenuDisplay()
        {
            e1 e1 = new e1();
            e2 e2 = new e2();
            e3 e3 = new e3();
            e4 e4 = new e4();
            e5 e5 = new e5();
            e6 e6 = new e6();
            e7 e7 = new e7();
            e8 e8 = new e8();
            e10 e10 = new e10();
            e11 e11 = new e11();
            e12 e12 = new e12();
            e13 e13 = new e13();
            e14 e14 = new e14();
            e15 e15 = new e15();
            e16 e16 = new e16();
            e17 e17 = new e17();
            e18 e18 = new e18();
            e19 e19 = new e19();
            e20 e20 = new e20();
            Match match = new Match();
            while (true)
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("MAIN MENU");
                    Console.WriteLine("---------");
                    Console.WriteLine("1.  CIRCLE & SPHERE");
                    Console.WriteLine("2.  NUMBERS IN DESCENDING ORDER");
                    Console.WriteLine("3.  TRIANGLE");
                    Console.WriteLine("4.  NEGATIVE or POSITIVE");
                    Console.WriteLine("5.  CALCULATOR");
                    Console.WriteLine("6.  TRUE");
                    Console.WriteLine("7.  AVERAGE");
                    Console.WriteLine("8.  CUBOID");
                    Console.WriteLine("10. MEASUREMENT CONVERSIONS");
                    Console.WriteLine("11. DIVISIBLE by 9?");
                    Console.WriteLine("12. NUMBER OF DIGITS");
                    Console.WriteLine("13. MONTHS");
                    Console.WriteLine("14. PROFIT OF YEAR");
                    Console.WriteLine("15. LANGUAGE TEST");
                    Console.WriteLine("16. PASSWORD");
                    Console.WriteLine("17. MONTHS 2");
                    Console.WriteLine("18. MEAN TEMPERATURE OF THE YEAR");
                    Console.WriteLine("19. COFFEE MACHINE");
                    Console.WriteLine("20. MONEY COUNTER");
                    Console.WriteLine("63. MATCH?");
                    Console.WriteLine("0. EXIT".PadLeft(25));
                    int userInput = int.Parse(Console.ReadLine());
                    switch (userInput)
                    {
                        case 1: e1.Circle(); break;
                        case 2: e2.DescOrder(); break;
                        case 3: e3.Triangle(); break;
                        case 4: e4.NorP(); break;
                        case 5: e5.Calc(); break;
                        case 6: e6.TrueOrFalse(); break;
                        case 7: e7.Average(); break;
                        case 8: e8.Cuboid(); break;
                        case 10: e10.WieghtToHektoLiterDeciliter(); break;
                        case 11: e11.DivisibleBy9(); break;
                        case 12: e12.HowManyNumChar(); break;
                        case 13: e13.Month(); break;
                        case 14: e14.Profit(); break;
                        case 15: e15.LanguageTest();break;
                        case 16: e16.Password();break;
                        case 17: e17.Month2();break;
                        case 18: e18.MeanTemperatureOfTheYear();break;
                        case 19: e19.CoffeeMachine();break;
                        case 20: e20.Cash();break;
                        case 63: match.PairMatch();break;
                        case 0: break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                break;
            

            }
        }
    }
}
