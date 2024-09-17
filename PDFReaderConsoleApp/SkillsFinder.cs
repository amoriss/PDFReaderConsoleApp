using PDFReaderConsoleApp.Models;

namespace PDFReaderConsoleApp;

public static class SkillsFinder
{
    public static void FindBackEndSkillsFromResume(string pageText, BackEndSkills backEndSkills)
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
}