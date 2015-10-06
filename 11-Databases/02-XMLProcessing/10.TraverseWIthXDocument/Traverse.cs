// Problem 10
// Rewrite Problem 09 using XDocument, XElement and XAttribute.

namespace TraverseDirectoryXDocument
{
    using System;
    using System.IO;
    using System.Xml.Linq;

    public class Traverse
    {
        public static void Main()
        {
            var result = new XElement("directory");
            result.Add(TraverseDirectories("../../"));

            string resultFileName = "result.xml";
            string resultFilePath = string.Format("../../{0}", resultFileName);

            result.Save(resultFilePath);

            Console.WriteLine("The result is recoreded in {0}", resultFileName);
        }

        private static XElement TraverseDirectories(string dir)
        {
            var element = new XElement("dir", new XAttribute("path", dir));

            foreach (var directory in Directory.GetDirectories(dir))
            {
                element.Add(TraverseDirectories(directory));
            }

            foreach (var file in Directory.GetFiles(dir))
            {
                element.Add(new XElement("file", new XAttribute("name", Path.GetFileName(file))));
            }

            return element;
        }
    }
}
