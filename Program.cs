//using System.Drawing;

using System;
using static System.Collections.Specialized.BitVector32;

namespace Polymorphism_in_OOP;

class Program
{
    static void Main(string[] args)
    {
        
        GeoMetry[] shapes = new GeoMetry[5];
        

        /* values of the properties of different shapes are fixed and provided
        through parameters while calling the constructors. But it is possible
        to have runtime user defined values. It is in the next version.*/

        /*
        shapes[0] = new RecTangle(6, 13);
        shapes[1] = new SquAre(5);
        shapes[2] = new CirCle(4);
        shapes[3] = new ParalleLogram(7, 4);
        shapes[4] = new ElliPse(5, 3);

        for (int i = 0; i < shapes.Length; i++)
        {
            Console.WriteLine($"Area of {shapes[i].GetType().Name}: {shapes[i].Area()}");
            //Console.ReadLine();
        }

        */

        /**********************************************************************/
        /**** user defined values of the properties for different shapes ******/
        /**********************************************************************/

        
        // Section: Rectangle
        Console.Write("Enter the value for rectangle length: ");
        double rectangleLength = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the value for rectangle width: ");
        double rectangleWidth = Convert.ToDouble(Console.ReadLine());
        RecTangle rectangle = new RecTangle(rectangleLength, rectangleWidth);
        Console.WriteLine($"Area of the Rectangle: {rectangle.Area()}");

        // Section: Square
        Console.Write("Enter the value for suare's side: ");
        double squareSide = Convert.ToDouble(Console.ReadLine());
        SquAre square = new SquAre(squareSide);
        Console.WriteLine($"Area of the Square: {square.Area()}");

        // Section: Circle
        Console.Write("Enter the radius of the circle: ");
        double circleRadius = Convert.ToDouble(Console.ReadLine());
        CirCle circle = new CirCle(circleRadius);
        Console.WriteLine($"Area of the Circle: {circle.Area()}");

        // Section: Parallelogram
        Console.Write("Enter the value for parallelogram base: ");
        double pgBase = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the value for parallelogram height: ");
        double pgHeight = Convert.ToDouble(Console.ReadLine());
        ParalleLogram parallelogram = new ParalleLogram(pgBase, pgHeight);
        Console.WriteLine($"Area of the Parallelogram: {parallelogram.Area()}");

        // Section: Ellipse
        Console.Write("Enter the value for ellipse's semi major axis: ");
        double ellipseSemimajoraxis = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the value for ellipse's semi minor axis: ");
        double ellipseSemiminoraxis = Convert.ToDouble(Console.ReadLine());
        ElliPse ellipse = new ElliPse(ellipseSemimajoraxis, ellipseSemiminoraxis);
        Console.WriteLine($"Area of the Ellipse: {ellipse.Area()}");

        



        Console.ReadLine();
    }
}

