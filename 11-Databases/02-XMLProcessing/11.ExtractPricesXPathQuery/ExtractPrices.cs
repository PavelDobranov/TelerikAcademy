// Problem 11
// Write a program, which extract from the file catalog.xml the prices for all albums, published 5 years ago or earlier.
// Use XPath query.

namespace ExtractPricesXPathQuery
{
    using System;
    using System.Xml;

    public class ExtractPrices
    {
        public static void Main()
        {
            XmlDocument catalogue = new XmlDocument();
            catalogue.Load("../../../01.CreateXML/catalogue.xml");

            string xPathQuery = "/catalogue/album";

            XmlNodeList albumList = catalogue.SelectNodes(xPathQuery);

            int yearsBeforeCount = 5;
            int maxValidYear = DateTime.Now.Year - yearsBeforeCount;

            foreach (XmlNode album in albumList)
            {
                int albumPublishedYear = int.Parse(album.SelectSingleNode("year").InnerText);

                if (albumPublishedYear <= maxValidYear)
                {
                    double albumPrice = double.Parse(album.SelectSingleNode("price").InnerText);
                    string albumName = album.SelectSingleNode("name").InnerText;
                    Console.WriteLine("Album {0}, released in {1}, price {2:C2}", albumName, albumPublishedYear, albumPrice);
                }                
            }
        }
    }
}
