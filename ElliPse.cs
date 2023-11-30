using System;
namespace Polymorphism_in_OOP
{
	public class ElliPse:GeoMetry
	{
        // own properties for ellipse
        public double SemimajorAxis { get; set; }
        public double SemiminorAxis { get; set; }


        // ellipse object constructor
        public ElliPse(double semimajorAx, double semiminorAx)
        {
            SemimajorAxis = semimajorAx;
            SemiminorAxis = semiminorAx;
        }


        // method to calculate area of the ellipse
        public override double Area()
        {
            return Math.PI * SemimajorAxis * SemiminorAxis;
        }
    }
}

