using Cv.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cv.Core.Data
{
    public interface ISkillRepository
    {
        Task<Skill> Get(int id);
        Task<List<Skill>> GetAll();
    }
}