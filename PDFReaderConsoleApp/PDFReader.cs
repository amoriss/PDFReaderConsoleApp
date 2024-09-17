using System.Reflection.Metadata;
using PDFReaderConsoleApp.Models;
using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;
using UglyToad.PdfPig.Graphics.Operations.PathPainting;

namespace PDFReaderConsoleApp;

public class PDFReader
{
    private static readonly string _relativePath =
        //concatenate path
        Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "FakeResume_1.pdf");

    public static void PrintTextFromPDFToConsole()
    {
       
    }

    public static void ReadAllPagesFromResume()
    {
        try
        {
            //using statement makes sure resources are properly disposed of after use.
            using (PdfDocument document = PdfDocument.Open(_relativePath))
            {
                int counter = 0;
                foreach (Page page in document.GetPages())
                {
                    counter++;
                    Console.WriteLine($"Reading page: {counter}.");
                    var pageText = page.Text.ToLower();
                    Console.WriteLine("------------------------");
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static void SetSkillsFromResume(string pageText, Skills skills)
    {
        if (pageText.Contains("visual studio"))
        {
            skills.UsesVisualStudio = true;
        }

        if (pageText.Contains("c#"))
        {
            skills.UsesCSharp = true;
        }

        if (pageText.Contains("asp.net"))
        {
            skills.UsesAspnet = true;
        }

        if (pageText.Contains("sql"))
        {
            skills.UsesSql = true;
        }
    }

    public static void GetSkillsFromResume(Skills skills)
    {
        if (skills.UsesCSharp)
        {
            Console.WriteLine("Language: C#");
        }

        if (skills.UsesAspnet)
        {
            Console.WriteLine("Framework: ASP.NET");
        }

        if (skills.UsesVisualStudio)
        {
            Console.WriteLine("IDE: Visual Studio");
        }

        if (skills.UsesSql)
        {
            Console.WriteLine("Database: SQL");
        }
        else if (!skills.UsesCSharp && !skills.UsesAspnet && !skills.UsesVisualStudio && !skills.UsesSql)
        {
            Console.WriteLine("This candidate does not have tools and languages you are looking for.");
        }
    }
}