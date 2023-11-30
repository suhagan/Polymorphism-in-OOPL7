using System;
namespace Polymorphism_in_OOP
{
    class cclassParallelogram : pclassGeometry
    {
        //own properties of Parallelogram
        public double Base { get; set; }
        public double Height { get; set; }

        //parallelogram object constructor
        public cclassParallelogram(double @base, double height)
        {
            Base = @base;
            Height = height;
        }

        // method to calculate area
        public override double Area()
        {
            return Base * Height;
        }
    }
}

