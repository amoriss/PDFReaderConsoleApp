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
            Console.WriteLine("This candidate does not have tools and languages you are looking for.");
        }
    }
}