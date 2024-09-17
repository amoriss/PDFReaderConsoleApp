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
            using (PdfDocument document = PdfDocument.Open(_relativePath))
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

    public static void SetSkillsFromResume(string pageText, BackEndSkills backEndSkills)
    {
        if (pageText.Contains("visual studio"))
        {
            backEndSkills.UsesVisualStudio = true;
        }

        if (pageText.Contains("c#"))
        {
            backEndSkills.UsesCSharp = true;
        }

        if (pageText.Contains("asp.net") || (pageText.Contains("asp")))
        {
            backEndSkills.UsesAspnet = true;
        }

        if (pageText.Contains("sql"))
        {
            backEndSkills.UsesSql = true;
        }
    }

    public static void GetSkillsFromResume(BackEndSkills backEndSkills)
    {
        if (backEndSkills.UsesCSharp)
        {
            Console.WriteLine("Language: C#");
        }

        if (backEndSkills.UsesAspnet)
        {
            Console.WriteLine("Framework: ASP.NET");
        }

        if (backEndSkills.UsesVisualStudio)
        {
            Console.WriteLine("IDE: Visual Studio");
        }

        if (backEndSkills.UsesSql)
        {
            Console.WriteLine("Database: SQL");
        }
        else if (!backEndSkills.UsesCSharp && !backEndSkills.UsesAspnet && !backEndSkills.UsesVisualStudio &&
                 !backEndSkills.UsesSql)
        {
            Console.WriteLine("This candidate does not have tools and languages you are looking for.");
        }
    }
}