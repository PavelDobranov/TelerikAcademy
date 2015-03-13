namespace CoordinateSystem
{
    using System;
    using System.Collections.Generic;

    public class Path
    {
        private List<Point3D> points;

        public Path() : this(null) { }

        public Path(List<Point3D> points)
        {
            this.Points = points;
        }

        public List<Point3D> Points
        {
            get
            {
                return new List<Point3D>(this.points);
            }
            private set
            {
                if (value == null)
                {
                    this.points = new List<Point3D>();
                }
                else
                {
                    this.points = new List<Point3D>(value);
                }
            }
        }

        public int Count
        {
            get
            {
                return this.Points.Count;
            }
        }


        public void AddPoint(Point3D point)
        {
            this.points.Add(point);
        }

        public void RemovePointAt(int index)
        {
            this.points.RemoveAt(index);
        }

        public void RemovePoint(Point3D point)
        {
            this.points.Remove(point);
        }

        public Point3D this[int index]
        {
            get
            {
                return points[index];
            }

            set
            {
                points[index] = value;
            }
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, this.Points);
        }
    }
}