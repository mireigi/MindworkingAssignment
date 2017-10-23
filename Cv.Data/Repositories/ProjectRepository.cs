using Cv.Core.Data;
using System.Threading.Tasks;
using Cv.Core.Models;
using System.Collections.Generic;
using System.Linq;
using Cv.Data.Source.InMemory;

namespace Cv.Data.InMemory
{
    public class ProjectRepository : _BaseRepository, IProjectRepository
    {

        public ProjectRepository(DataSource dataSource) : base(dataSource)
        {
        }

        public Task<Project> Get(int id)
        {
            return Task.FromResult(_dataSource.Projects.FirstOrDefault(project => project.Id == id));
        }

        public Task<List<Project>> GetAll()
        {
            return Task.FromResult(_dataSource.Projects);
        }
    }
}