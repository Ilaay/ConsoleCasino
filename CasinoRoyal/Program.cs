using System;

namespace CasinoRoyal
{
    class Program
    {
        static int money = 100;
        static void WinLose()
        {
            if(money < 1)
            {
                Console.WriteLine("Game over!!!");
                Environment.Exit(0);
            }
            if(money > 1000)
            {
                Console.WriteLine("You WIN!!!");
                Environment.Exit(0);
            }
        }
        static void Balance()
        {
            Console.WriteLine("Your balance: " + money);
        }
        static void Roulete()
        {
            Console.WriteLine("Make your bet!");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("1 - Red");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("2 - Black");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("3 - Green");
            Console.ResetColor();
            Console.WriteLine("---------");
            Console.WriteLine("Your bet: ");
            int bet = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your money: ");
            int moneybet = Convert.ToInt32(Console.ReadLine());

            if (moneybet > money)
            {
                Console.WriteLine("Error! You have not enough money\n");
                Balance();
            }
            else
            {
                money = money - moneybet;
                Random random = new Random();
                int chance = random.Next(1, 101);
                if (chance <= 99)   // 98%
                {
                    int chance2 = random.Next(1, 2);
                    if (chance2 == 1)
                    {
                        Console.WriteLine("Red sector!");
                        if (bet == 1)
                        {
                            Console.WriteLine("Congratulations! x2 Multiplier!\n");
                            money = money + moneybet * 2;
                            Balance();
                        }
                        else if (bet != 1)
                        {
                            Console.WriteLine("Sorry)\n");
                            Balance();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Black sector!");
                        if (bet == 2)
                        {
                            Console.WriteLine("Congratulations! x2 Multiplier!\n");
                            money = money + moneybet * 2;
                            Balance();
                        }
                        else if (bet != 2)
                        {
                            Console.WriteLine("Sorry)\n");
                            Balance();
                        }
                    }
                }
                else if (chance > 99)
                {
                    Console.WriteLine("Green Jackpot sector!");
                    if (bet == 3)
                    {
                        Console.WriteLine("Congratulations! x100 Multiplier!\n");
                        money = money + moneybet * 100;
                        Balance();
                    }
                    else if (bet != 1)
                    {
                        Console.WriteLine("Sorry) That was a real chance)\n");
                        Balance();
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to CasinoRoyal!");
            while (true)
            {
                WinLose();
                Roulete();
            }
        }
    }
}
