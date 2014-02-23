using System;
using System.Collections.Generic;

namespace Shapes
{
    class ShapeTesting
    {
        static void Main()
        {
            List<Shape> geometricalObjects = new List<Shape>();
            geometricalObjects.Add(new Circle(3.5));
            geometricalObjects.Add(new Rectangle(3, 4));
            geometricalObjects.Add(new Triangle(5, 4));
            geometricalObjects.Add(new Rectangle(7.6, 5.2));
            geometricalObjects.Add(new Triangle(10.3, 17));
            geometricalObjects.Add(new Circle(5.7));

            foreach (var shape in geometricalObjects)
            {
                Console.WriteLine("{0} -> Area: {1}", shape.GetType(), shape.CalculateSurface());
            }
        }
    }
}