using System;
namespace Polymorphism_in_OOP
{
	public class cclassEllipse:pclassGeometry
	{
        // own properties for ellipse
        public double majorAxis { get; set; }
        public double minorAxis { get; set; }


        // ellipse object constructor
        public cclassEllipse(double majorAx, double minorAx)
        {
            majorAxis = majorAx;
            minorAxis = minorAx;
        }


        // method to calculate area of the ellipse
        public override double Area()
        {
            return Math.PI * majorAxis * minorAxis;
        }
    }
}

