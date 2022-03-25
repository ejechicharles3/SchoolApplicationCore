using Microsoft.EntityFrameworkCore;
using SchoolApplication.GenericRepository.Interface;
using SchoolApplicationCore.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApplicationCore.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly DatabaseContext _context;
        private readonly DbSet<T> _db;

        public Repository(DatabaseContext context)
        {
            _context = context;
            _db = _context.Set<T>();
        }
        public async Task Add(T entity) => await _db.AddAsync(entity);

        public async Task AddRange(IEnumerable<T> entities) => await _db.AddRangeAsync(entities);

        public async Task Delete(int id)
        {
           var entity = await _db.FindAsync(id);
            _db.Remove(entity);
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            _db.RemoveRange(entities);
        }

        public async Task<IList<T>> GetAll()
        {
            return await _db.AsNoTracking().ToListAsync();
        }

        public async Task<T> GetById(Guid Id)
        {
            return await _db.SingleAsync(x => x.Id == Id);
        }

        public void Update(T entity)
        {
            _db.Update(entity);
        }

        public void UpdateRange(T entities)
        {
            _db.UpdateRange(entities);
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            return _db.Where<T>(expression);
        }
    }
}
