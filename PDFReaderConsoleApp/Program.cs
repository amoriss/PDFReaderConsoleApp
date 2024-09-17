using PDFReaderConsoleApp;
using PDFReaderConsoleApp.Models;

//PDFReader.ReadAllPagesFromResume();
var resumeText = PDFReader.GetFullResumeTextAsString();
var applicant1 = new BackEndSkills();
PDFReader.SetSkillsFromResume(resumeText, applicant1);
Console.WriteLine();
Console.WriteLine();
PDFReader.GetSkillsFromResume(applicant1);