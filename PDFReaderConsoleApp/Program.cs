// See https://aka.ms/new-console-template for more information

using PDFReaderConsoleApp;
using PDFReaderConsoleApp.Models;

//PDFReader.ReadAllPagesFromResume();
var resumeText = PDFReader.GetFullResumeTextAsString();
var applicant1 = new Skills();
PDFReader.SetSkillsFromResume(resumeText, applicant1);
Console.WriteLine();
Console.WriteLine();
PDFReader.GetSkillsFromResume(applicant1);