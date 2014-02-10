namespace EuclideanSpace
{
    using System;

    class EuclideanSpace
    {
        static void Main()
        {
            //Testing

            //creating some points
            Point3D firstPoint = new Point3D(3, 0, 4);
            Console.WriteLine("First point: {0}", firstPoint);
            Point3D zeroPoint = Point3D.PointZero;
            Console.WriteLine("Zero point: {0}", zeroPoint);
            Point3D anotherPoint = new Point3D(4, 5, 2);
            Console.WriteLine("Another point: {0}", anotherPoint);

            //calculating the distance between different points
            double result = CalculateDistance.Calculate(firstPoint, zeroPoint);
            Console.WriteLine("Distance between the first point and the zero point: {0}", result);
            result = CalculateDistance.Calculate(zeroPoint, anotherPoint);
            Console.WriteLine("Distance between the zero point and another point: {0}", result);

            //creating a path of points
            Path testPath = new Path();
            testPath.AddPoint(firstPoint);
            testPath.AddPoint(zeroPoint);
            testPath.AddPoint(anotherPoint);

            //saving the path to the file Path.txt
            PathStorage.Save(testPath);

            //loading a path from the file Path.txt
            Path testPath2 = PathStorage.Load();
        }
    }
}
