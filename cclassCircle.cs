using System;
namespace Polymorphism_in_OOP
{
	public class cclassCircle:pclassGeometry
	{
        // properties for circle
        public double circleRadius { get; set; }

        // constructor circle
        public cclassCircle(double raDius)
        {
            circleRadius = raDius;
        }

        // method to calculate area of the circle
        public override double Area()
        {
            return Math.PI * circleRadius * circleRadius;
        }
    }
}

