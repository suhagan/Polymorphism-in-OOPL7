using System;
namespace Polymorphism_in_OOP
{
	public class cclassSquare: pclassGeometry
	{
        /*  special property of square is all arms are of same length. 
         *  so, created one special property: squareSide.
        */

        public double squareSideA { get; set; }


        //constructor to creat object
        public cclassSquare(double sideArmA)
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

