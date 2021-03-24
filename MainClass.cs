using System;

namespace CSharp_Stuff
{
   class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            TutorialOne();
        }

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
    }
}
