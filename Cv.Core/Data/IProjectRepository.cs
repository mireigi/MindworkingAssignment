using Cv.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cv.Core.Data
{
    public interface IProjectRepository
    {
        Task<Project> Get(int id);
        Task<List<Project>> GetAll();

    }
}