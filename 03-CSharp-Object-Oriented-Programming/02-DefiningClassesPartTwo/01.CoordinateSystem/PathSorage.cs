namespace CoordinateSystem
{
    using System;
    using System.IO;
    using System.Linq;

    public static class PathSorage
    {
        public static Path LoadPath(string filePath)
        {
            StreamReader reader = new StreamReader(filePath);

            Path path = new Path();

            using (reader)
            {
                string currentLine = reader.ReadLine();

                char[] separators = new char[] { '(', ' ', ')' };

                while (currentLine != null)
                {
                    double[] currentPointCoords = currentLine.Split(separators, StringSplitOptions.RemoveEmptyEntries)
                                                             .Select(c => double.Parse(c))
                                                             .ToArray();

                    path.AddPoint(new Point3D(currentPointCoords[0], currentPointCoords[1], currentPointCoords[2]));

                    currentLine = reader.ReadLine();
                }
            }

            return path;
        }

        public static void SavePath(Path path, string filePath)
        {
            StreamWriter writer = new StreamWriter(filePath, true);

            using (writer)
            {
                for (int point = 0; point < path.Count; point++)
                {
                    writer.WriteLine(path[point]);
                }
            }
        }
    }
}