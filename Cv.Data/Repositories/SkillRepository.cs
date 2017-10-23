using Cv.Core.Data;
using System.Threading.Tasks;
using Cv.Core.Models;
using System.Collections.Generic;
using System.Linq;
using Cv.Data.Source.InMemory;

namespace Cv.Data.InMemory
{
    public class SkillRepository : _BaseRepository, ISkillRepository
    {
        public SkillRepository(DataSource dataSource) : base(dataSource)
        {
        }

        public Task<Skill> Get(int id)
        {
            return Task.FromResult(_dataSource.Skills.FirstOrDefault(skill => skill.Id == id));
        }

        public Task<List<Skill>> GetAll()
        {
            return Task.FromResult(_dataSource.Skills);
        }
    }
}