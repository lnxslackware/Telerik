using System;

namespace MobilePhone.Library
{
    public class Display
    {
        private double? size;
        private int? colors;

        public Display() : this(null, null)
        {

        }

        public Display(double? size) : this(size, null)
        {

        }

        public Display(double? size, int? colors)
        {
            this.Size = size;
            this.Colors = colors;
        }

        public double? Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Size cannot be less than zero.");
                }

                this.size = value;
            }
        }

        public int? Colors
        {
            get
            {
                return this.colors;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Colors cannot be less than zero.");
                }

                this.colors = value;
            }
        }
    }
}
