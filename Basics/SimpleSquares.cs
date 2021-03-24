using System;

namespace CSharp_Stuff
{
    /*
    Simple squares is used as a basic introduction for variables, classes and methods
    */
   class SimpleSquares
    {
        public static string AreaOfAKeyboard()
        {
            int lengthCm = 30;
            int widthCm = 8;
            return("The area of this keyboard is: " + widthCm * lengthCm + " " + "cm");
        }
        public static int AreaOfASquare(int height, int width)
        {
            int area = height * width;
            return(area);
        }
    }
}
