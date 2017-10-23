using Cv.Core.Models;
using GraphQL.Types;

namespace Cv.GraphQL.Models
{
    public class ProjectType : ObjectGraphType<Project>
    {
        public ProjectType()
        {
            Field(x => x.Id).Description("The Id of the Project.");
            Field(x => x.Name, nullable: true).Description("The name of the Project.");
            Field("Company", x => x.ForCompany, true, typeof(CompanyType)).Description("The company the Project was undertaken for.");
            Field(x => x.Description).Description("What solution the Project sought to provide.");
        }
    }
}