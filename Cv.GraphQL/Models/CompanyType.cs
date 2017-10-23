using Cv.Core.Models;
using GraphQL.Types;

namespace Cv.GraphQL.Models
{
    public class CompanyType : ObjectGraphType<Company>
    {
        public CompanyType()
        {
            Field(x => x.Id).Description("The Id of the Company.");
            Field(x => x.Name, nullable: true).Description("The name of the Company.");
            Field(x => x.DateStarted).Description("The year and month employment began at the Company.");
            Field(x => x.DateLeft).Description("The year and month employment ended at the Company.");
            Field(x => x.WorkDescription).Description("What kind of work the employment at the Company entailed.");
        }
    }
}