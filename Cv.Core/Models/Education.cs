using System;

namespace Cv.Core.Models
{
    public class Education
    {
        public int Id { get; }
        public string Name { get; }
        public DateTime GraduationDate { get; }
        public string TaughtAt { get; }

        public Education(int id, string name, DateTime graduationDate, string taughtAt)
        {
            Id = id;
            Name = name;
            GraduationDate = graduationDate;
            TaughtAt = taughtAt;
        }
    }
}