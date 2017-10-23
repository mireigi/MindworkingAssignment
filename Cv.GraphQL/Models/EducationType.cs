using Cv.Core.Models;
using GraphQL.Types;

namespace Cv.GraphQL.Models
{
    public class EducationType : ObjectGraphType<Education>
    {
        public EducationType()
        {
            Field(x => x.Id).Description("The Id of the Education.");
            Field(x => x.Name, nullable: true).Description("The name of the Education.");
            Field(x => x.TaughtAt).Description("Where the Education was taken.");
            Field(x => x.GraduationDate).Description("The month and year graduation from the Education took place.");
        }
    }
}