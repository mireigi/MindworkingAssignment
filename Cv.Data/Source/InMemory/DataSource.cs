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
            Skills.Add(new Skill(1, "C#", SkillProficiency.High));
            Skills.Add(new Skill(2, "MSSQL", SkillProficiency.MediumHigh));
        }

        private void DefineEducations()
        {
            Educations.Add(new Education(1, "Datamatiker", new DateTime(2008, 4, 25), "Vejle IT-skole"));
        }

        private void DefineCompanies()
        {
            Companies.Add(new Company(1, "Senzor /v Horsens Folkeblad", new DateTime(2008, 4, 28), new DateTime(2011, 5, 31), "Design websites."));
        }

        private void DefineProjects()
        {
            Projects.Add(new Project(1, "Coloplast User-innovation Experience", Companies.First(c => c.Id == 1), "Website hvor brugere af Coloplast produkter kan dele deres egne innovationer, eller arbejde sammen om nye. Målet hermed at Coloplast kan samarbejde med brugerne for at tilpasse eller udvikle nye produkter."));
        }
    }
}