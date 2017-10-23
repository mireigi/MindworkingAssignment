using Cv.Core.Models;
using GraphQL.Types;

namespace Cv.GraphQL.Models
{
    public class SkillType : ObjectGraphType<Skill>
    {
        public SkillType()
        {
            Field(x => x.Id).Description("The Id of the Skill.");
            Field(x => x.Name, nullable: true).Description("The name of the Skill.");
            Field("Proficiency", x => $"{x.Proficiency}").Description("The proficiency with the Skill, ranging from Low to High.");
        }
    }
}