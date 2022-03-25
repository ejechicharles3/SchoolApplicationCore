using SchoolApplication.GenericRepository.Interface;
using SchoolApplicationCore.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApplicationCore.Data.Repositories
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class, IEntity
    {
        private readonly DatabaseContext _context;
        private IRepository<T> _repository;
        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }
        public IRepository<T> Repository => _repository ??= new Repository<T>(_context);

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
