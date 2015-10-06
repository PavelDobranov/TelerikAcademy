// Problem 06
// Rewrite the same from Problem 05 using XDocument and LINQ query.

namespace ExtractSongTitlesXDocument
{
    using System;
    using System.Collections;
    using System.Linq;
    using System.Xml.Linq;

    public class ExtractSongTitles
    {
        public static void Main()
        {
            XDocument catalogue = XDocument.Load("../../../01.CreateXML/catalogue.xml");

            var songs =
                from song in catalogue.Descendants("song")
                select song.Element("title").Value;

            PrintSongs(songs);
        }

        private static void PrintSongs(IEnumerable songs)
        {
            foreach (var song in songs)
            {
                Console.WriteLine(song);
            }
        }
    }
}
