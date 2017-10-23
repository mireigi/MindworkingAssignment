using Cv.Core;
using Cv.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cv.Data.Source.InMemory
{
    public class DataSource
    {
        internal List<Skill> Skills { get; }
        internal List<Education> Educations { get; }
        internal List<Company> Companies { get; }
        internal List<Project> Projects { get; }

        public DataSource()
        {
            Skills = new List<Skill>();
            Educations = new List<Education>();
            Companies = new List<Company>();
            Projects = new List<Project>();

            DefineSkills();
            DefineEducations();
            DefineCompanies();
            DefineProjects();
        }

        private void DefineSkills()
        {
            // Developer skills
            Skills.Add(new Skill(1, "C#", SkillProficiency.High));
            Skills.Add(new Skill(2, "nHibernate og Fluent nHibernate", SkillProficiency.Medium));
            Skills.Add(new Skill(3, "Domain Driven Design", SkillProficiency.MediumHigh));
            Skills.Add(new Skill(4, "T-SQL", SkillProficiency.High));
            Skills.Add(new Skill(5, "LINQ / Entity Framework", SkillProficiency.High));
            Skills.Add(new Skill(6, "ASP.NET", SkillProficiency.High));
            Skills.Add(new Skill(7, "AJAX og Javascript / jQuery", SkillProficiency.MediumHigh));
            Skills.Add(new Skill(8, "XML og XSLT", SkillProficiency.MediumHigh));
            Skills.Add(new Skill(9, "HTML og CSS", SkillProficiency.High));
            Skills.Add(new Skill(10, "Classic ASP", SkillProficiency.High));
            Skills.Add(new Skill(11, "Java", SkillProficiency.MediumLow));
            Skills.Add(new Skill(12, "MSSQL", SkillProficiency.MediumHigh));
            Skills.Add(new Skill(13, "Scrum", SkillProficiency.MediumHigh));

            // User skills
            Skills.Add(new Skill(14, "Softship", SkillProficiency.MediumHigh));
            Skills.Add(new Skill(15, "Microsoft Server 2000 - 2008", SkillProficiency.Medium));
            Skills.Add(new Skill(16, "Microsoft Windows 95 - Win 10", SkillProficiency.Medium));
            Skills.Add(new Skill(17, "Microsoft BizTalk 2009", SkillProficiency.MediumHigh));
            Skills.Add(new Skill(18, "Microsoft Team Foundation Server 2009 - 2015", SkillProficiency.MediumHigh));


            // Superuser skills
            Skills.Add(new Skill(19, "Office 2000 - 2012", SkillProficiency.High));
            Skills.Add(new Skill(20, "Visual Studio 2005 - 2015", SkillProficiency.High));
            Skills.Add(new Skill(21, "Microsoft SQL Server 2005 - 2014", SkillProficiency.High));

            // Languages
            Skills.Add(new Skill(22, "Dansk (Læse, skrive, forstå)", SkillProficiency.High));
            Skills.Add(new Skill(23, "Engelsk (Læse, skrive, forstå)", SkillProficiency.High));
            Skills.Add(new Skill(24, "Tysk (Læse, skrive, forstå)", SkillProficiency.Low));

        }

        private void DefineEducations()
        {
            Educations.Add(new Education(1, "3-årig HHX", new DateTime(2004, 6, 30), "Business College Horsens"));
            Educations.Add(new Education(2, "Datamatiker", new DateTime(2008, 4, 25), "Vejle IT-skole"));
            Educations.Add(new Education(3, "Tre dages kursus i Avanceret SQL", new DateTime(2012, 2, 1), "Teknologisk Institut Århus"));
        }

        private void DefineCompanies()
        {
            Companies.Add(new Company(1, "Temp-Team Horsens", "Produktionsvikar", new DateTime(2004, 8, 1), new DateTime(2005, 6, 30), "Produktions/logistik relateret arbejde for Hatting Bageri, Scandisleep, Scanpress og BB Electronics A/S."));
            Companies.Add(new Company(2, "Senzor /v Horsens Folkeblad", "Webudvikler", new DateTime(2008, 4, 28), new DateTime(2011, 5, 31), "Daglig drift af systemer. Uddannelse af kunder. Kundesupport. Webudvikling. Relancering af koncernens webportal."));
            Companies.Add(new Company(3, "Unifeeder A/S", "IT-coordinator", new DateTime(2011, 6, 1), new DateTime(2013, 5, 31), "Daglig drift af systemer. Udvikling af systemer. EDI med kunder. Udvikling til og brug af BizTalk 2009. Projektledelse. Fælles udvikling med ekstern systemleverandør."));
            Companies.Add(new Company(4, "Spain-Holiday", "Systemudvikler", new DateTime(2014, 8, 1), new DateTime(2017, 5, 31), "Daglig support af system. Udvikling af systemer, inklusive komplet booking system med betalingsportal. Integration af data med partnere."));

        }

        private void DefineProjects()
        {
            Projects.Add(new Project(1, "Coloplast User-innovation Experience", Companies.First(c => c.Id == 1), "Website hvor brugere af Coloplast produkter kan dele deres egne innovationer, eller arbejde sammen om nye. Målet hermed at Coloplast kan samarbejde med brugerne for at tilpasse eller udvikle nye produkter."));
            Projects.Add(new Project(2, "Spain-Holiday Booking", Companies.First(c => c.Id == 4), "Opgradering af Spain-Holiday's website til at tilbyde online booking af ferieboliger i Spanien, med samarbejde med ekstern betalingspartner."));
        }
    }
}