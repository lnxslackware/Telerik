namespace EuclideanSpace
{
    using System;

    public static class CalculateDistance
    {
        public static double Calculate(Point3D first, Point3D second)
        {
            int differenceX = Math.Abs(first.X - second.X);
            int differenceY = Math.Abs(first.Y - second.Y);
            int differenceZ = Math.Abs(first.Z - second.Z);

            return Math.Sqrt(differenceX * differenceX + differenceY * differenceY + differenceZ * differenceZ);
        }
    }
}
