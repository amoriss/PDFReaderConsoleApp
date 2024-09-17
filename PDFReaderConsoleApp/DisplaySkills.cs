using PDFReaderConsoleApp.Models;

namespace PDFReaderConsoleApp;

public class DisplaySkills
{
    public static void DisplayBackEndSkillsFromResume(BackEndSkills backEndSkills)
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
            Console.WriteLine("This candidate does not have any back-end skills.");
        }
    }

    public static void DisplayFrontEndSkillsFromResume(FrontEndSkills frontEndSkills)
    {
        if (frontEndSkills.UsesJavaScript)
        {
            Console.WriteLine("Language: JavaScript");
        }

        if (frontEndSkills.UsesCss)
        {
            Console.WriteLine("Language: JavaScript");
        }

        if (frontEndSkills.UsesReact)
        {
            Console.WriteLine("Framework: React");
        }
        
        else if (!frontEndSkills.UsesJavaScript || !frontEndSkills.UsesCss || !frontEndSkills.UsesReact)
        {
            Console.WriteLine("This candidate does not have front-end skills.");
        }
    }
}