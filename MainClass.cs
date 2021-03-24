using System;

namespace CSharp_Stuff
{
   class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //TutorialOne();
            TutorialTwo();
        }

        /*
        Tutorial one introduces basic I/O, variables, different data types, methods and multi-class interaction
        */
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
    }
}
