using System;

namespace Shapes
{
    public abstract class Shape
    {
        protected double width;
        protected double height;

        protected Shape(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public abstract double CalculateSurface();
    }
}
