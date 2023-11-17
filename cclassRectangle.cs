using System;
namespace Polymorphism_in_OOP
{
	public class cclassRectangle:pclassGeometry
	{
        
            // properties
            public double reclenGth { get; set; }
            public double recwiDth { get; set; }

            // constructor to
            public cclassRectangle(double lenGth, double wiDth)
            {
                reclenGth = lenGth;
                recwiDth = wiDth;
            }

            // method to calculate area
            public override double Area()
            {
                double rectArea;
                return rectArea = reclenGth * recwiDth;
            }
        
    }
}

