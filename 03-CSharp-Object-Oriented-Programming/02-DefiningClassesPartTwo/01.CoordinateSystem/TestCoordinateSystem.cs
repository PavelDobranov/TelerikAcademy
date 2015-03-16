// Problem 1. Structure
// Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
// Implement the ToString() to enable printing a 3D point.

// Problem 2. Static read-only field
// Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
// Add a static property to return the point O.

// Problem 3. Static class
// Write a static class with a static method to calculate the distance between two points in the 3D space.

// Problem 4. Path
// Create a class Path to hold a sequence of points in the 3D space.
// Create a static class PathStorage with static methods to save and load paths from a text file.
// Use a file format of your choice.

namespace CoordinateSystem
{
    using System;

    class TestCoordinateSystem
    {
        static void Main()
        {
            Path path = new Path();

            path.AddPoint(new Point3D(-7, -4, 3));
            path.AddPoint(new Point3D(33.5, 12, 18));
            path.AddPoint(new Point3D(17, 6, 2.5));
            path.AddPoint(new Point3D(44.4, 12, 6));

            Console.WriteLine("Path: {0}", path);

            Console.WriteLine("Distance between {0} and {1}: {2:F3}", path[0], path[1], PointsCalculator.CalculateDistance(path[0], path[1]));

            string filePath = @"../../points.txt";

            path.RemovePoint(path[0]);

            PathSorage.SavePath(path, filePath);

            Path loadedPath = PathSorage.LoadPath(filePath);

            Console.WriteLine("Loaded path: {0}", loadedPath);

            string serializedPointsPath = @"../../serializedPoints.txt";

            PathSorage.SerializePath(path, serializedPointsPath);

            Path deserializedPath = PathSorage.DeserializePath(serializedPointsPath);

            Console.WriteLine("Deserialize path: {0}", deserializedPath);
        }
    }
}