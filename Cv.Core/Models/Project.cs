namespace Cv.Core.Models
{
    public class Project
    {
        public int Id { get; }
        public string Name { get; }
        public Company ForCompany { get; }
        public string Description { get; }

        public Project(int id, string name, Company forCompany, string description)
        {
            Id = id;
            Name = name;
            ForCompany = forCompany;
            Description = description;
        }
    }
}