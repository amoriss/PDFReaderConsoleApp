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
        bool usesCSharp = true;
        bool usesVisualStudio = true;
        bool usesSQL = true;
        try
        {
            using (PdfDocument document = PdfDocument.Open(relativePath))
            {
                int counter = 0;
                foreach (Page page in document.GetPages())
                {
                    counter++;
                    Console.WriteLine($"Reading page: {counter}.");
                    var pageText = page.Text;
                    // Console.WriteLine(pageText);
                    // Console.WriteLine("------------------------");
                    // Console.WriteLine();
                    // Console.WriteLine($"The candidates skills on page {counter}: ");
                    Console.WriteLine("------------------------");

                    if (pageText.ToLower().Contains("visual studio"))
                    {
                        //Console.WriteLine("This candidate can use visual studio.");
                        usesVisualStudio = true;
                    }

                    if (pageText.ToLower().Contains("c#"))
                    {
                        //Console.WriteLine("This candidate uses C#.");
                        usesCSharp = true;
                    }
                    // else
                    // {
                    //     Console.WriteLine("This candidate is not eligible.");
                    // }

                    // switch (true)
                    // {
                    //     case var _ when pageText.ToLower().Contains("simple"):
                    //         Console.WriteLine("document contains the word simple");
                    //         break;
                    //     case var _ when pageText.ToLower().Contains("doc"):
                    //         Console.WriteLine("document contains the word doc");
                    //         break;
                    //     default:
                    //         Console.WriteLine("no specific word found.");
                    //         break;
                    // }


                    //Console.WriteLine(pageText);
                    // foreach(Word word in page.GetWords())
                    // {
                    //     Console.WriteLine(word.Text);
                    // }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        if (usesCSharp == true)
        {
            Console.WriteLine("Language: C#");
        }

        if (usesVisualStudio == true)
        {
            Console.WriteLine("IDE: Visual Studio");
        }
        else
        {
            Console.WriteLine("This candidate does not have tools and languages you are looking for.");
        }
    }
}