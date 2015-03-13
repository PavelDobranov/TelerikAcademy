namespace CoordinateSystem
{
    using System;

    public static class PointsCalculator
    {
        public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
            double deltaX = secondPoint.CoordX - firstPoint.CoordX;
            double deltaY = secondPoint.CoordY - firstPoint.CoordY;
            double deltaZ = secondPoint.CoordZ - firstPoint.CoordZ;

            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
        }
    }
}