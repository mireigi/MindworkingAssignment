using Cv.Data.Source.InMemory;

namespace Cv.Data.InMemory
{
    public abstract class _BaseRepository
    {
        protected readonly DataSource _dataSource;

        public _BaseRepository(DataSource dataSource)
        {
            _dataSource = dataSource;
        }
    }
}