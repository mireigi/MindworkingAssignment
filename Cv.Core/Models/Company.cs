using System;

namespace Cv.Core.Models
{
    public class Company
    {
        public int Id { get; }
        public string Name { get; }
        public string PositionTitle { get; set; }
        public DateTime DateStarted { get; }
        public DateTime DateLeft { get; }
        public string WorkDescription { get; }

        public Company(int id, string name, string positionTitle, DateTime dateStarted, DateTime dateLeft, string workDescription)
        {
            Id = id;
            Name = name;
            PositionTitle = positionTitle;
            DateStarted = dateStarted;
            DateLeft = dateLeft;
            WorkDescription = workDescription;
        }
    }
}