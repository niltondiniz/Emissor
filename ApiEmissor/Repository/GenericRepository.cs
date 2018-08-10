using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiEmissor.DataLayer;

namespace ApiEmissor.Repository
{
    public abstract class GenericRepository<T> : BaseContext<T>, IUnitOfWork<T> where T : class
    {


        public GenericRepository()
        {
        }

        public int Count()
        {
            return this.Set<T>().Count();
        }

        public async Task<int> CountAsync()
        {
            return await this.Set<T>().CountAsync();
        }

        public virtual void Delete(T model)
        {
            this.Set<T>().Remove(model);
            this.SaveChanges();
        }

        public async Task<int> DeleteAsync(T entity)
        {
            this.Set<T>().Remove(entity);
            return await this.SaveChangesAsync();
        }

        public T Find(Expression<Func<T, bool>> match)
        {
            return this.Set<T>().SingleOrDefault(match);
        }

        public ICollection<T> FindAll(Expression<Func<T, bool>> match)
        {
            return this.Set<T>().Where(match).ToList();
        }

        public async Task<ICollection<T>> FindAllAsync(Expression<Func<T, bool>> match)
        {
            return await this.Set<T>().Where(match).ToListAsync();
        }

        public async Task<T> FindAsync(Expression<Func<T, bool>> match)
        {
            return await this.Set<T>().SingleOrDefaultAsync(match);
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = this.Set<T>().Where(predicate);
            return query;
        }

        public async Task<ICollection<T>> FindByAsyn(Expression<Func<T, bool>> predicate)
        {
            return await this.Set<T>().Where(predicate).ToListAsync();
        }

        public IEnumerable<T> GetAll()
        {
            return this.Set<T>().ToList<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await this.Set<T>().ToListAsync<T>();
        }

        public T GetById(object id)
        {
            var objeto = this.Set<T>().Find(id);
            return objeto;
        }

        public IEnumerable<T> OrderBy(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public int Save(T model)
        {
            this.Set<T>().Add(model);
            return this.SaveChanges();
        }

        public async Task<int> SaveAsync(T t)
        {
            this.Set<T>().Add(t);
            return await this.SaveChangesAsync();
        }

        public int Update(T model)
        {
            var entry = this.Entry(model);
            if (entry.State == EntityState.Detached)
                this.Set<T>().Attach(model);

            return this.SaveChanges();

        }

        public async Task<int> UpdateAsync(T t, object key)
        {
            if (t == null)
                return 0;
            T exist = await this.Set<T>().FindAsync(key);
            if (exist != null)
            {
                this.Entry<T>(exist).CurrentValues.SetValues(t);
                await this.SaveChangesAsync();
            }
            return 1;
        }

        public IEnumerable<T> Where(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
