using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises1_20_1
{
    class e20
    {
        public void Cash()
        {
            Menu menu = new Menu();
            Console.WriteLine();
            Console.WriteLine("MONEY COUNTER");
            Console.WriteLine("(Press ENTER if you want to quit)");
            Console.WriteLine("---------------");

            int fiveCoin = 0;
            int tenCoin = 0;
            int twentyCoin = 0;
            int fiftyCoin = 0;
            int oneHundredCoin = 0;
            int twoHundredCoin = 0;
            int fiveHundredBankNote = 0;
            int oneThousandBankNote = 0;
            int twoThousandBankNote = 0;
            int fiveThousandBankNote = 0;
            int tenThousandBankNote = 0;
            int twentyThousandBankNote = 0;

            while (true)
            {
                Console.Write("Type a price (Ft): ");
                int userMoney = int.Parse(Console.ReadLine());

                try
                {
                    twentyThousandBankNote = userMoney / 20000;
                    userMoney = userMoney - (twentyThousandBankNote * 20000);

                    tenThousandBankNote = userMoney / 10000;
                    userMoney = userMoney - (tenThousandBankNote * 10000);

                    fiveThousandBankNote = userMoney / 5000;
                    userMoney = userMoney - (fiveThousandBankNote * 5000);

                    twoThousandBankNote = userMoney / 2000;
                    userMoney = userMoney - (twoThousandBankNote * 2000);

                    oneThousandBankNote = userMoney / 1000;
                    userMoney = userMoney - (oneThousandBankNote * 1000);

                    fiveHundredBankNote = userMoney / 500;
                    userMoney = userMoney - (fiveHundredBankNote * 500);

                    twoHundredCoin = userMoney / 200;
                    userMoney = userMoney - (twoHundredCoin * 200);

                    oneHundredCoin = userMoney / 100;
                    userMoney = userMoney - (oneHundredCoin * 100);

                    fiftyCoin = userMoney / 50;
                    userMoney = userMoney - (fiftyCoin * 50);

                    twentyCoin = userMoney / 20;
                    userMoney = userMoney - (twentyCoin * 20);

                    tenCoin = userMoney / 10;
                    userMoney = userMoney - (tenCoin * 10);

                    fiveCoin = userMoney / 5;
                    userMoney = userMoney - (fiveCoin * 5);

                    Console.WriteLine("20.000 Ft Banknote = " + twentyThousandBankNote);
                    Console.WriteLine("10.000 Ft Banknote = " + tenThousandBankNote);
                    Console.WriteLine("5.000 Ft Banknote = " + fiveThousandBankNote);
                    Console.WriteLine("2.000 Ft Banknote = " + twoThousandBankNote);
                    Console.WriteLine("1.000 Ft Banknote = " + oneThousandBankNote);
                    Console.WriteLine("500 Ft Banknote = " + fiveHundredBankNote);
                    Console.WriteLine("200 Ft Coin = " + twoHundredCoin);
                    Console.WriteLine("100 Ft Coin = " + oneHundredCoin);
                    Console.WriteLine("50 Ft Coin = " + fiftyCoin);
                    Console.WriteLine("20 Ft Coin = " + twentyCoin);
                    Console.WriteLine("10 Ft Coin = " + tenCoin);
                    Console.WriteLine("5 Ft Coin = " + fiveCoin);
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
