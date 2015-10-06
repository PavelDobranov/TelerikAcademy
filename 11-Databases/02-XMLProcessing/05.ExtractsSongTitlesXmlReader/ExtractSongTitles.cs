// Problem 05
// Write a program, which using XmlReader extracts all song titles from catalogue.xml.

namespace ExtractsSongTitlesXmlReader
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    public class ExtractSongTitles
    {
        public static void Main()
        {
            var songs = new List<string>();

            using (XmlReader reader = XmlReader.Create("../../../01.CreateXML/catalogue.xml"))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "title")
                    {
                        var song = reader.ReadElementString();
                        songs.Add(song);
                    }
                }
            }

            PrintSongs(songs);
        }

        private static void PrintSongs(IEnumerable<string> songs)
        {
            foreach (var song in songs)
            {
                Console.WriteLine(song);
            }
        }
    }
}
