namespace EuclideanSpace
{
    public struct Point3D
    {
        private static Point3D pointZero = new Point3D(0, 0, 0);

        public Point3D(int x, int y, int z) : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public int Z { get; set; }

        public static Point3D PointZero {
            get
            {
                return pointZero;
            }
        }

        public override string ToString()
        {
            return string.Format("X:{0} Y:{1} Z:{2}", X, Y, Z);
        }

    }
}
