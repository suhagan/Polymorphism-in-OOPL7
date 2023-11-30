using System;
namespace Polymorphism_in_OOP
{
	public class cclassCircle:pclassGeometry
	{
        // own properties for circle
        public double circleRadius { get; set; }

        // circle object constructor
        public cclassCircle(double raDius)
        {
            circleRadius = raDius;
        }

        // method to calculate area
        public override double Area()
        {
            return Math.PI * circleRadius * circleRadius;
        }
    }
}

