using System.Reflection.Metadata;
using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;
using UglyToad.PdfPig.Graphics.Operations.PathPainting;

namespace PDFReaderConsoleApp;

public class PDFReader
{
    public static void PrintTextFromPDFToConsole()
    {
        string relativePath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "FakeResume_1.pdf");
        bool usesCSharp = false;
        bool usesVisualStudio = false;
        bool usesSql = false;
        bool usesAspnet = false;
        try
        {
            //using statement makes sure resources are properly disposed of after use.
            using (PdfDocument document = PdfDocument.Open(relativePath))
            {
                int counter = 0;
                foreach (Page page in document.GetPages())
                {
                    counter++;
                    Console.WriteLine($"Reading page: {counter}.");
                    var pageText = page.Text.ToLower();
                    Console.WriteLine("------------------------");

                    if (pageText.Contains("visual studio"))
                    {
                        usesVisualStudio = true;
                    }

                    if (pageText.Contains("c#"))
                    {
                        usesCSharp = true;
                    }

                    if (pageText.Contains("asp.net"))
                    {
                        usesAspnet = true;
                    }

                    if (pageText.Contains("sql"))
                    {
                        usesSql = true;
                    }
                    
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        if (usesCSharp)
        {
            Console.WriteLine("Language: C#");
        }

        if (usesAspnet)
        {
            Console.WriteLine("Framework: ASP.NET");
        }

        if (usesVisualStudio)
        {
            Console.WriteLine("IDE: Visual Studio");
        }

        if (usesSql)
        {
            Console.WriteLine("Database: SQL");
        }
        else if(!usesCSharp && !usesAspnet && !usesVisualStudio && !usesSql)
        {
            Console.WriteLine("This candidate does not have tools and languages you are looking for.");
        }
    }
}