using System;
namespace Polymorphism_in_OOP
{
	public class SquAre: GeoMetry
	{
        /*  special property of square is all arms are of same length. 
         *  so, created one special property: squareSide.
        */

        public double squareSideA { get; set; }


        //constructor to creat object
        public SquAre(double sideArmA)
        {
            squareSideA = sideArmA;
        }

        // method to calculate area
        public override double Area()
        {
            double squareArea;
            return squareArea = squareSideA * squareSideA;
        }
    }
}

