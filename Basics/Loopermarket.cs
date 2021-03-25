    using System;

    namespace CSharp_Stuff
    {
        /*
        Going round in circles builds upon knowledge learned in Tutorial one and two.
        In this class, we introduce different ways to implement iteration.
        */
        class Loopermarket
        {
            public static int ChocolateBars()
            {
                Console.WriteLine("You have £2 and want to buy some chocolate bars at the shop.");
                Console.WriteLine("Chocolate bars are 50p each, how many will you buy? (0 - 4)");
                int numOfBars = int.Parse(Console.ReadLine());
                do
                {
                    if(numOfBars < 0)
                    {
                        Console.WriteLine("Thats not enough chocolate bars!");
                        numOfBars = int.Parse(Console.ReadLine());
                    }
                    else if(numOfBars > 4)
                    {
                        Console.WriteLine("Too many chocolate bars, you cant afford that!");
                        numOfBars = int.Parse(Console.ReadLine());
                    }
                }
                while(numOfBars < 0 || numOfBars > 4);
                return(numOfBars);
            }

            public static int ShoppingSimulation()
            {
                Console.WriteLine("You decide to go for the weekly shop at the supermarket.");
                Console.WriteLine("How many aisles will you go down?");
                int aisles = int.Parse(Console.ReadLine());
                int total = 0;
                for(int i = 0; i < aisles; i+=1)
                {
                    Console.WriteLine("You are currently in aisle: " + (i+1) + " how many £ do you spend?");
                    total += int.Parse(Console.ReadLine());
                }
                return(total);
            }
        }
    }