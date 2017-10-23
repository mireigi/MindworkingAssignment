using Cv.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cv.Core.Data
{
    public interface ICompanyRepository
    {
        Task<Company> Get(int id);
        Task<List<Company>> GetAll();
    }
}