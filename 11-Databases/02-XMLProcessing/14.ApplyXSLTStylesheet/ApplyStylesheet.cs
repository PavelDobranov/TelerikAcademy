// Problem 14
// Write a C# program to apply the XSLT stylesheet transformation on the file catalog.xml using the class

namespace ApplyXSLTStylesheet
{
    using System;
    using System.Xml.Xsl;

    public class ApplyStylesheet
    {
        public static void Main()
        {
            var catalogXslTransform = new XslCompiledTransform();

            string resultFileName = "result.html";
            string resultFilePath = string.Format("../../{0}", resultFileName);

            catalogXslTransform.Load("../../../13.CreateXSLStylesheet/catalogue.xsl");

            catalogXslTransform.Transform("../../../01.CreateXML/catalogue.xml", resultFilePath);

            Console.WriteLine("The result is recoreded in {0}", resultFileName);
        }
    }
}
