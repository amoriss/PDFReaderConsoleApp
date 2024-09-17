using PDFReaderConsoleApp;
using PDFReaderConsoleApp.Models;

//PDFReader.ReadAllPagesFromResume();
var resumeText = PdfReader.GetFullResumeTextAsString();
var applicant1 = new BackEndSkills();
SkillsFinder.FindBackEndSkillsFromResume(resumeText, applicant1);
Console.WriteLine();
Console.WriteLine();
DisplaySkills.DisplayBackEndSkillsFromResume(applicant1);