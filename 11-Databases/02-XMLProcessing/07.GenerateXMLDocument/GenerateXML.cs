// Problem 07
// In a text file we are given the name, address and phone number of given person (each at a single line).
// Write a program, which creates new XML document, which contains these data in structured XML format.

namespace GenerateXMLDocument
{
    using System;
    using System.IO;
    using System.Xml.Linq;

    public class GenerateXML
    {
        public static void Main()
        {
            string[] data = File.ReadAllLines("../../persons-data.txt");
            string[] personDataFields = { "name", "address", "phone" };

            XElement root = new XElement("persons");

            for (int personIndex = 0; personIndex < data.Length; personIndex += personDataFields.Length)
            {
                var person = new XElement("person");

                for (int dataFieldIndex = 0; dataFieldIndex < personDataFields.Length; dataFieldIndex++)
                {
                    person.Add(new XElement(personDataFields[dataFieldIndex], data[personIndex + dataFieldIndex]));
                }

                root.Add(person);
            }

            string resultFilename = "result.xml";

            Console.WriteLine("The final result is recoreded in {0}", resultFilename);
            root.Save(string.Format("../../{0}", resultFilename));
        }
    }
}
