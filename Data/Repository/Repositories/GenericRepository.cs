using Getir.Data.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Getir.Data.Repository.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly GetirDbContext _dbcontext;
        protected readonly DbSet<T> _set;

        public GenericRepository(GetirDbContext dbcontext)
        {
            _dbcontext = dbcontext;
            _set = dbcontext.Set<T>();
        }

        public Task AddAsync(T entity)
        {
            return _set.AddAsync(entity).AsTask(); //its because addasync is mostly sync in rare cases becomes async 
        }
        public void Delete(T entity)
        {
            _set.Remove(entity);
        }
        public async Task<T?> GetByIdAsync(Guid id)
        {
            return await _set.FindAsync(id);
        }
        public void Update(T entity)
        {
            _set.Update(entity);
        }
        public IQueryable<T> Query()
        {
            return _set.AsQueryable();
        }
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _set.ToListAsync();
        }

    }
}
