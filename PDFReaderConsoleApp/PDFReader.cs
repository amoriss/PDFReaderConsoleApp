using System.Reflection.Metadata;
using PDFReaderConsoleApp.Models;
using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;
using UglyToad.PdfPig.Graphics.Operations.PathPainting;

namespace PDFReaderConsoleApp;

public class PdfReader
{
    private static readonly string RelativePath =
        //concatenate path
        Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "FakeResume_1.pdf");

    public static void ReadAllPagesFromResume()
    {
        try
        {
            //using statement makes sure resources are properly disposed of after use.
            using (PdfDocument document = PdfDocument.Open(RelativePath))
            {
                int counter = 0;
                foreach (Page page in document.GetPages())
                {
                    counter++;
                    Console.WriteLine($"Reading page: {counter}:");
                    Console.WriteLine();
                    Console.WriteLine(page.Text);
                    Console.WriteLine("------------------------");
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static string GetFullResumeTextAsString()
    {
        try
        {
            using (PdfDocument document = PdfDocument.Open(RelativePath))
            {
                string pageText = string.Empty;
                foreach (Page page in document.GetPages())
                {
                    pageText += page.Text.ToLower();
                }

                return pageText;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return null;
        }
    }

  

   
}