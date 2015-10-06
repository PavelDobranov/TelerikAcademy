// Problem 04
// Using the DOM parser write a program to delete from catalogue.xml all albums having price > 20.

namespace DeleteAlbums
{
    using System;
    using System.Xml;

    public class DeleteAlbums
    {
        private const double MaxPrice = 20;

        public static void Main()
        {
            XmlDocument catalogue = new XmlDocument();
            catalogue.Load("../../../01.CreateXML/catalogue.xml");

            XmlNode rootNode = catalogue.DocumentElement;

            foreach (XmlNode node in catalogue.DocumentElement)
            {
                double price = double.Parse(node["price"].InnerText);

                if (price > MaxPrice)
                {
                    rootNode.RemoveChild(node);
                }
            }

            string resultFilename = "result.xml";

            Console.WriteLine("The result is recoreded in {0}", resultFilename);
            catalogue.Save(string.Format("../../{0}", resultFilename));
        }
    }
}
