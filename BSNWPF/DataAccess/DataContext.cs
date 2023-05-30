
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BSNWPF.Back.DataAccess
{
    public class DataContext<T> where T : class
    {
        private readonly DbContext _dbContext;
        public DataContext(DbContext dbContext  ) 
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<T>> SelectLists()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> Select(Expression<Func<T,bool>> predicate )
        {
            return await _dbContext.Set<T>().Where(predicate).FirstAsync();
        }
        public void Disapose ()
        {
            _dbContext.Dispose();
        }
    }
}
