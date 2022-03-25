using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository.Interface
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> Where(Expression<Func<T, bool>> expression);

        Task<IList<T>> GetAll();

        Task<T> GetById(Guid Id);

        Task Add(T entity);

        Task AddRange(IEnumerable<T> entities);

        void Update(T entity);

        void UpdateRange(T entities);

        void Delete(T entity);

        void DeleteRange(IEnumerable<T> entities);

    }
}
