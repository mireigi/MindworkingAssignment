using Cv.GraphQL.Queries;
using GraphQL;
using GraphQL.Types;
using System.Threading.Tasks;

namespace Cv.GraphQL
{
    public class GraphQueryService
    {
        private readonly Schema _schema;

        public GraphQueryService(MultiQuery query)
        {
            _schema = new Schema { Query = query };
        }

        public async Task<ExecutionResult> Execute(GraphQLQuery query)
        {
            return await new DocumentExecuter().ExecuteAsync(_ =>
            {
                _.Schema = _schema;
                _.Query = query.Query;

            }).ConfigureAwait(false);
        }
    }
}