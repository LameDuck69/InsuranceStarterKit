using Pocos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Data.Entity.Infrastructure;

#pragma warning disable 0001
namespace Repos.GenericRepos
{
    public class RepositoryBase<T> : IRepository<T> where T : class
    {

        protected InsuranceDbContext dbContext;

        protected DbSet<T> DbSet;
        
        public RepositoryBase( InsuranceDbContext context )
        {
            string exString = @"Null DbContext";

            if (dbContext == null)
                throw new ArgumentNullException(exString);
            dbContext = context;
            DbSet = context.Set<T>();
        }
        
        public virtual IEnumerable<T> GetAll()
        {
            return DbSet;
        }

        public IEnumerable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {

            IEnumerable<T> query = DbSet.Where(predicate).AsEnumerable();
            return query;
        }

        public virtual T GetById(int id)
        {
            return DbSet.Find(id);
        }

        public virtual void Add(T entity)
        {
            DbEntityEntry dbEntityEntry = dbContext.Entry(entity);
            if (dbEntityEntry.State != EntityState.Detached)
            {
                dbEntityEntry.State = EntityState.Added;
            }
            else
            {
                DbSet.Add(entity);
            }
        }

        public virtual void Update(T entity)
        {
            DbEntityEntry dbEntityEntry = dbContext.Entry(entity);
            if (dbEntityEntry.State == EntityState.Detached)
            {
                DbSet.Attach(entity);
            }
            dbEntityEntry.State = EntityState.Modified;
        }

        public virtual void Delete(T entity)
        {
            DbEntityEntry dbEntityEntry = dbContext.Entry(entity);
            if (dbEntityEntry.State != EntityState.Deleted)
            {
                dbEntityEntry.State = EntityState.Deleted;
            }
            else
            {
                DbSet.Attach(entity);
                DbSet.Remove(entity);
            }
        }

        public virtual void Delete(int id)
        {
            var entity = GetById(id);
            if (entity == null) return; // not found; assume already deleted.
            Delete(entity);
        }

        public void Save()
        {
            dbContext.SaveChanges();
        }
    }
}
