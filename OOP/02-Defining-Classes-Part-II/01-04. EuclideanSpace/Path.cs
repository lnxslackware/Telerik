namespace EuclideanSpace
{
    using System.Collections.Generic;

    public class Path
    {
        List<Point3D> path;

        public List<Point3D> GetPath
        {
            get
            {
                return this.path;
            }
        }

        public Path()
        {
            path = new List<Point3D>();
        }

        public void AddPoint(Point3D point)
        {
            this.path.Add(point);
        }
    }
}