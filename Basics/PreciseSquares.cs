using System;

namespace CSharp_Stuff
{
     /*
    Safer squares builds upon the SimpleSquares class used in tutorial one
    In this class, we introduce the double datatype, this helps make our measurements more precise.
    */
    class PreciseSquares
    {
        public static double AreaOfAPreciseSquare(double height, double width)
        {
            double area = height * width;
            return(area);
        }
    }
}