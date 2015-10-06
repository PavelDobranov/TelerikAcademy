// Problem 12
// Write a program, which extract from the file catalog.xml the prices for all albums, published 5 years ago or earlier.
// Use LINQ query.

namespace ExtractPricesLinq
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    public class ExtractPrices
    {
        public static void Main()
        {
            XDocument catalogue = XDocument.Load("../../../01.CreateXML/catalogue.xml");

            int yearsBeforeCount = 5;
            int maxValidYear = DateTime.Now.Year - yearsBeforeCount;

            var albums =
                from album in catalogue.Descendants("album")
                where int.Parse(album.Element("year").Value) <= maxValidYear
                select new
                {
                    Name = album.Element("name").Value,
                    Year = int.Parse(album.Element("year").Value),
                    Price = double.Parse(album.Element("price").Value)
                };

            foreach (var album in albums)
            {
                Console.WriteLine("Album {0}, released in {1}, price {2:C2}", album.Name, album.Year, album.Price);
            }
        }
    }
}
