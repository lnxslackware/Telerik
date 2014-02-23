using System;

namespace Shapes
{
    class Circle : Shape
    {
        public Circle(double radius)
            : base(radius, radius)
        {

        }

        public override double CalculateSurface()
        {
            return (Math.PI * this.width) * (Math.PI * this.width);
        }
    }
}