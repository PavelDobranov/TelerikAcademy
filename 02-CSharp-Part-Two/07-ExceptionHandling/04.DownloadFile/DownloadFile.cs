// Problem 4. Download file
// Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
// Find in Google how to download files in C#.
// Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Security;

class DownloadFile
{
    static void Main()
    {
        Console.WriteLine("Enter the full download URL: ");
        string urlInput = Console.ReadLine();

        string fileName = Path.GetFileName(urlInput);

        WebClient client = new WebClient();

        using (client)
        {
            try
            {
                client.DownloadFile(urlInput, fileName);

                Console.WriteLine("Download complete!");

                Process process = new Process();
                process.StartInfo.FileName = fileName;
                process.Start();

            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please provide a URL address!"); ;
            }
            catch (WebException)
            {
                Console.WriteLine("Make sure the URL is valid, the file you want to download exists and the internet connection is running!");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The method have out of range calls!");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}