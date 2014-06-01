namespace CohesionAndCoupling
{
    using System;

    static class Utils3D
    {
        public static double CalcDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) +
                (y2 - y1) * (y2 - y1) +
                (z2 - z1) * (z2 - z1));
            return distance;
        }

        public static double CalcVolume(double width, double height, double depth)
        {
            double volume = width * height * depth;
            return volume;
        }

        public static double CalcDiagonalXyz(double width, double height, double depth)
        {
            double distance = CalcDistance3D(0, 0, 0, width, height, depth);
            return distance;
        }

        public static double CalcDiagonalXZ(double width, double depth)
        {
            double distance = Math.Sqrt((width - 0) * (width - 0) +
                (depth - 0) * (depth - 0));
            return distance;
        }

        public static double CalcDiagonalYZ(double height, double depth)
        {
            double distance = CalcDiagonalXZ(height, depth);
            return distance;
        }
    }
}
