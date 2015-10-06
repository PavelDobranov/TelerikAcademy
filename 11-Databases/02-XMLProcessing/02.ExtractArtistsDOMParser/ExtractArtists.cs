// Problem 02
// Write program that extracts all different artists which are found in the catalogue.xml.
// For each author you should print the number of albums in the catalogue.
// Use the DOM parser and a hash-table.

namespace ExtractArtistsDOMParser
{
    using System;
    using System.Collections;
    using System.Xml;

    public class ExtractArtists
    {
        public static void Main()
        {
            XmlDocument catalogue = new XmlDocument();
            catalogue.Load("../../../01.CreateXML/catalogue.xml");

            Hashtable artists = new Hashtable();

            XmlNode rootNode = catalogue.DocumentElement;

            foreach (XmlNode node in rootNode.ChildNodes)
            {
                var artistName = node["artist"].InnerText;

                if (!artists.ContainsKey(artistName))
                {
                    artists.Add(node["artist"].InnerText, 1);
                }
                else
                {
                    var lastvalue = (int)artists[artistName];
                    artists[artistName] = ++lastvalue;
                }
            }

            PrintArtists(artists);
        }

        private static void PrintArtists(Hashtable artists)
        {
            foreach (var item in artists.Keys)
            {
                Console.WriteLine("{0} => {1} albums", item, artists[item]);
            }
        }
    }
}