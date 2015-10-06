// Problem 16
// Using Visual Studio generate an XSD schema for the file catalog.xml.
// Write a C# program that takes an XML file and an XSD file (schema) and validates the XML file against the schema.
// Test it with valid XML catalogs and invalid XML catalogs.

namespace CreteXSDSchema
{
    using System;
    using System.Xml.Linq;
    using System.Xml.Schema;

    public class CreteXSDSchema
    {
        public static void Main()
        {
            var schema = new XmlSchemaSet();
            schema.Add(null, "../../catalogueSchema.xsd");

            var catalogue = XDocument.Load("../../../01.CreateXML/catalogue.xml");
            var invalidCatalogue = XDocument.Load("../../invalid-catalogue.xml");

            ValidateXML(catalogue, schema);
            // ValidateXML(invalidCatalogue, schema);
        }

        private static void ValidateXML(XDocument xmlDoc, XmlSchemaSet schema)
        {
            bool isValidXml = true;

            xmlDoc.Validate(schema, (o, ev) =>
            {
                Console.WriteLine(ev.Message);
                isValidXml = false;
            });

            Console.WriteLine("{0} XML file", isValidXml ? "Valid" : "Invalid");
        }
    }
}