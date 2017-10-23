using System.Web.Http;
using Cv.GraphQL;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;

namespace Cv.Api.Controllers
{
    [Route("graphql")]
    public class GraphQLController : ApiController
    {
        private readonly GraphQueryService _graphQueryService;

        public GraphQLController(GraphQueryService graphQueryService)
        {
            _graphQueryService = graphQueryService;
        }

        [HttpPost]
        public async Task<IHttpActionResult> Post([FromBody] GraphQLQuery query)
        {
            ExecutionResult result = await _graphQueryService.Execute(query);

            if (result.Errors?.Count > 0)
                return BadRequest(result.Errors?.Select(e => e.Message).FirstOrDefault());

            return Ok(result);
        }
    }
}