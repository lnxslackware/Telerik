using System;

namespace Shapes
{
    public class Triangle : Shape
    {
        public Triangle(double height, double width)
            : base(height, width)
        {

        }

        public override double CalculateSurface()
        {
            return (this.height * this.width) / 2;
        }
    }
}
