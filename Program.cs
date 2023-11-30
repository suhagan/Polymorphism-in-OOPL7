using System.Drawing;

namespace Polymorphism_in_OOP;

class Program
{
    static void Main(string[] args)
    {
        
        GeoMetry[] shapes = new GeoMetry[5];

        // values of the properties of different shapes are fixed and provided
        // through parameters while calling the constructors. But it is possible
        // to have runtime user defined values. It is in the next version.
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
        Console.ReadLine();
    }
}

