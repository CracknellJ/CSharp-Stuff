using System;

namespace CSharp_Stuff
{
   class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region Basic I/O, conditionals and datatypes
            //TutorialOne();
            //TutorialTwo();
            #endregion

            #region Iteration
            TutorialThree();
            //TutorialFour();
            #endregion
        }

        /*
        Tutorial one and two introduce basic I/O, variables, different data types, conditional statements, methods and multi-class interaction
        */
        #region Tutorial one and two
        public static void TutorialOne()
        {
            string areaOfMyKeyboard = SimpleSquares.AreaOfAKeyboard();
            Console.WriteLine(areaOfMyKeyboard);

            int areaOfASquare = SimpleSquares.AreaOfASquare(height:10, width:10);
            Console.WriteLine("The area of this square is: " + areaOfASquare + " metres");

            int windowHeight = int.Parse(Console.ReadLine());
            int windowWidth = int.Parse(Console.ReadLine());
            int areaOfMyWindow = SimpleSquares.AreaOfASquare(height:windowHeight, width:windowWidth);
            Console.WriteLine("The area of my window is: " + areaOfMyWindow);
            Console.ReadLine();
        }
        public static void TutorialTwo()
        {
            const double MAX_WIDTH = 20.0;
            const double MIN_WIDTH = 0.5;
            const double MAX_HEIGHT = 10.0;
            const double MIN_HEIGHT = 0.3;
            double width, height, area;

            Console.WriteLine("Enter the width of your square:");
            width = double.Parse(Console.ReadLine());
            if(width < MIN_WIDTH)
            {
                Console.WriteLine("Width entered is too small, using the minimum of " + MIN_WIDTH + " instead.");
                width = MIN_WIDTH;
            }
            if(width > MAX_WIDTH)
            {
                Console.WriteLine("Width entered is too large, using the maximum of " + MAX_WIDTH + " instead.");
                width = MAX_WIDTH;
            }

            Console.WriteLine("Enter the height of your square:");
            height = double.Parse(Console.ReadLine());
            if(height < MIN_HEIGHT)
            {
                Console.WriteLine("Height entered is too small, using the minimum of " + MIN_HEIGHT + " instead.");
                height = MIN_WIDTH;
            }
            if(width > MAX_WIDTH)
            {
                Console.WriteLine("Height entered is too large, using the maximum of " + MAX_HEIGHT + " instead.");
                height = MAX_WIDTH;
            }

            area = PreciseSquares.AreaOfAPreciseSquare(height, width);
            Console.WriteLine("The area of the square is: " + area);
            Console.ReadLine();
        }
        #endregion

        /*
        Tutorial three introduces iteration through do-while, while and for loops.
        */
        #region Tutorial three and four
        public static void TutorialThree()
        {
            //do-while loop (this will always complete at least one loop)
            Console.WriteLine("========= This is my do-while loop! =========");
            int myNumber = 0;
            do
            {
                myNumber = myNumber + 1;
                //myNumber += 1;
                Console.WriteLine(myNumber);
            } while (myNumber < 10);

            //while loop (this may not always complete a loop, think back to conditionals)
            Console.WriteLine("========== This is my while loop! ==========");
            int myOtherNumber = 0;
            while (myOtherNumber < 10)
            {
                myOtherNumber = myOtherNumber + 1;
                Console.WriteLine(myOtherNumber);
            }

            //for loop
            Console.WriteLine("=========== This is my for loop! ===========");
            int myFinalNumber;
            //initialise; conditional; update
            for(myFinalNumber = 0; myFinalNumber < 10; myFinalNumber += 1)
            {
                Console.WriteLine(myFinalNumber);
            }
            
            Console.WriteLine("");
            int chocolateBars = Loopermarket.ChocolateBars();
            Console.WriteLine("You bought " + chocolateBars + " chocolate bars, enjoy!");

            Console.WriteLine("");
            int totalSpend = Loopermarket.ShoppingSimulation();
            Console.WriteLine("You spent a total of £" + totalSpend + " in the supermarket.");
            Console.ReadLine();
        }

        public static void TutorialFour()
        {

        }
        #endregion
    }
}

