using Cv.Core.Data;
using System.Threading.Tasks;
using Cv.Core.Models;
using System.Collections.Generic;
using System.Linq;
using Cv.Data.Source.InMemory;

namespace Cv.Data.InMemory
{
    public class EducationRepository : _BaseRepository, IEducationRepository
    {
        public EducationRepository(DataSource dataSource) : base(dataSource)
        {
        }

        public Task<Education> Get(int id)
        {
            return Task.FromResult(_dataSource.Educations.FirstOrDefault(education => education.Id == id));
        }

        public Task<List<Education>> GetAll()
        {
            return Task.FromResult(_dataSource.Educations);
        }
    }
}