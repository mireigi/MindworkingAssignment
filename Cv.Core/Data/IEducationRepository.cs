using Cv.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cv.Core.Data
{
    public interface IEducationRepository
    {
        Task<Education> Get(int id);
        Task<List<Education>> GetAll();
    }
}