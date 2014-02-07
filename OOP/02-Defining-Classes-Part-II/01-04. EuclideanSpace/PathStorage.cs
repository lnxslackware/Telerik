using System;
using System.IO;
namespace EuclideanSpace
{
    public static class PathStorage
    {
        private static string filePath = "../../Path.txt";

        public static void Save(Path paths)
        {
            StreamWriter writer = new StreamWriter(filePath);

            using (writer)
            {
                foreach (var path in paths.GetPath)
                {
                    writer.WriteLine(string.Format("{0}, {1}, {2}", path.X, path.Y, path.Z));
                }
            }
        }

        public static Path Load()
        {
            Path result = new Path();
            StreamReader reader = new StreamReader(filePath);

            using (reader)
            {
                string readedLine = reader.ReadLine();
                string[] coordinates = readedLine.Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);
                
                while (readedLine != null)
                {
                    result.AddPoint(new Point3D(int.Parse(coordinates[0]), int.Parse(coordinates[1]), int.Parse(coordinates[2])));
                    readedLine = reader.ReadLine();
                }
            }

            return result;
        }
    }
}