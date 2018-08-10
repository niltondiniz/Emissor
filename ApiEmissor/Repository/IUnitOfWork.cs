using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ApiEmissor.Repository
{
    public interface IUnitOfWork<T> where T : class
    {
        int Save(T model);
        int Update(T model);
        void Delete(T model);
        IEnumerable<T> GetAll();
        T GetById(object id);
        IEnumerable<T> Where(Expression<Func<T, bool>> expression);
        IEnumerable<T> OrderBy(Expression<System.Func<T, bool>> expression);
        int Count();
        T Find(Expression<Func<T, bool>> match); 
        ICollection<T> FindAll(Expression<Func<T, bool>> match); 
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);


        Task<IEnumerable<T>> GetAllAsync();
        Task<int> SaveAsync(T t);
        Task<int> UpdateAsync(T t, object key);
        Task<int> DeleteAsync(T entity);
        Task<int> CountAsync();
        Task<T> FindAsync(Expression<Func<T, bool>> match); 
        Task<ICollection<T>> FindAllAsync(Expression<Func<T, bool>> match);
        Task<ICollection<T>> FindByAsyn(Expression<Func<T, bool>> predicate); 

    }
}
