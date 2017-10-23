namespace Cv.Core.Models
{
    public class Skill
    {
        public int Id { get; }
        public string Name { get; }
        public SkillProficiency Proficiency { get; }

        public Skill(int id, string name, SkillProficiency proficiency)
        {
            Id = id;
            Name = name;
            Proficiency = proficiency;
        }
    }
}