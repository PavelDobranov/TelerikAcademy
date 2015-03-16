namespace CoordinateSystem
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Runtime.Serialization.Formatters.Binary;

    public static class PathSorage
    {
        private static readonly char[] pointCoordsSeparators = new char[] { '[', ' ', ',', ']' };

        private static BinaryFormatter binaryFormatter;

        static PathSorage()
        {
            binaryFormatter = new BinaryFormatter();
        }

        public static void SavePath(Path path, string filePath)
        {
            StreamWriter writer = new StreamWriter(filePath, false);

            using (writer)
            {
                foreach (var point in path)
                {
                    writer.WriteLine(point);
                }
            }
        }

        public static Path LoadPath(string filePath)
        {
            StreamReader reader = new StreamReader(filePath);

            Path path = new Path();

            using (reader)
            {
                string currentLine = reader.ReadLine();

                while (currentLine != null)
                {
                    path.AddPoint(ParsePoint(currentLine));

                    currentLine = reader.ReadLine();
                }
            }

            return path;
        }

        public static void SerializePath(Path path, string filePath)
        {
            Stream stream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write);

            binaryFormatter.Serialize(stream, path);

            stream.Close();
        }

        public static Path DeserializePath(string filePath)
        {
            Stream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);

            Path path = (Path)binaryFormatter.Deserialize(stream);

            stream.Close();

            return path;
        }

        private static Point3D ParsePoint(string format)
        {
            double[] currentPointCoords = format.Split(pointCoordsSeparators, StringSplitOptions.RemoveEmptyEntries).Select(c => double.Parse(c)).ToArray();

            return new Point3D(currentPointCoords[0], currentPointCoords[1], currentPointCoords[2]);
        }
    }
}