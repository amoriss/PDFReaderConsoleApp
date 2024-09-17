using PDFReaderConsoleApp;
using PDFReaderConsoleApp.Models;

//PDFReader.ReadAllPagesFromResume();

//get resume instances
var resumeText = PdfReader.GetFullResumeTextAsString();
var applicant1BackEndSkills = new BackEndSkills();
var applicant1FrontEndSkills = new FrontEndSkills();

//find back-end skills
SkillsFinder.FindBackEndSkillsFromResume(resumeText, applicant1BackEndSkills);
//find front-end skills
SkillsFinder.FindFrontEndSkillsFromResume(resumeText, applicant1FrontEndSkills);

Console.WriteLine();
Console.WriteLine();

//display back-end skills
Console.WriteLine("Back-End: ");
DisplaySkills.DisplayBackEndSkillsFromResume(applicant1BackEndSkills);
Console.WriteLine();
//display front-end skills
Console.WriteLine("Front-End: ");
DisplaySkills.DisplayFrontEndSkillsFromResume(applicant1FrontEndSkills);