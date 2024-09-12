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
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Simple_doc_Helvetica_Neue_Font.pdf");
        try
        {
            using (PdfDocument document = PdfDocument.Open(relativePath))
            {
                foreach (Page page in document.GetPages())
                {
                    string pageText = page.Text;
                    foreach(Word word in page.GetWords())
                    {
                        Console.WriteLine(word.Text);
                    }

                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
     
        }
       
    }
}