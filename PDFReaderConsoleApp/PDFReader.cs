using System.Reflection.Metadata;
using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;

namespace PDFReaderConsoleApp;

public class PDFReader
{
    public static void PrintTextFromPDFToConsole()
    {
        try
        {
            using (PdfDocument document = PdfDocument.Open(@"Data/Simple_doc_Helvetica_Neue_Font.pdf"))
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