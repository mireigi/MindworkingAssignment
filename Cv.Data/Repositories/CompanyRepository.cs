using Cv.Core.Data;
using System.Threading.Tasks;
using Cv.Core.Models;
using System.Collections.Generic;
using System.Linq;
using Cv.Data.Source.InMemory;

namespace Cv.Data.InMemory
{
    public class CompanyRepository : _BaseRepository, ICompanyRepository
    {
        public CompanyRepository(DataSource dataSource) : base(dataSource)
        {
        }

        public Task<Company> Get(int id)
        {
            return Task.FromResult(_dataSource.Companies.FirstOrDefault(company => company.Id == id));
        }

        public Task<List<Company>> GetAll()
        {
            return Task.FromResult(_dataSource.Companies);
        }
    }
}