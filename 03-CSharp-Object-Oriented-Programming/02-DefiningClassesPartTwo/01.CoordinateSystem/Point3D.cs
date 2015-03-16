namespace CoordinateSystem
{
    using System;

    [Serializable]
    public struct Point3D
    {
        private const string ToStringFormat = "[ {0}, {1}, {2} ]";
        private const int OCoordX = 0;
        private const int OCoordY = 0;
        private const int OCoordZ = 0;

        private static readonly Point3D pointO = new Point3D(Point3D.OCoordX, Point3D.OCoordY, Point3D.OCoordZ);

        public Point3D(double coordX, double coordY, double coordZ)
            : this()
        {
            this.CoordX = coordX;
            this.CoordY = coordY;
            this.CoordZ = coordZ;
        }

        public double CoordX { get; set; }

        public double CoordY { get; set; }

        public double CoordZ { get; set; }

        public static Point3D PointO
        {
            get
            {
                return Point3D.pointO;
            }
        }

        public override string ToString()
        {
            return string.Format(Point3D.ToStringFormat, this.CoordX, this.CoordY, this.CoordZ);
        }
    }
}