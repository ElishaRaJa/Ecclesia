using Ecclesia.DataAccess.Data;
using Ecclesia.DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Ecclesia.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        internal DbSet<T> dbSet;

        public Repository(ApplicationDbContext db)
        {
            _db = db;
            this.dbSet = _db.Set<T>();
            //_db.Categories == dbSet
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

<<<<<<< Updated upstream
        public T Get(Expression<Func<T, bool>> filter)
=======
        public T Get(Expression<Func<T, bool>> filter, string? includeProperties = null, bool tracked = false)
>>>>>>> Stashed changes
        {
            IQueryable<T> query;
           
            if (tracked)
            {
                 query = dbSet;
            }
            else
            {
                query = dbSet.AsNoTracking();
            }
            query = query.Where(filter);
            return query.FirstOrDefault();
        }

<<<<<<< Updated upstream
        public IEnumerable<T> GetAll()
        {
            IQueryable<T> query = dbSet;
=======
        //Category,Covertype
        public IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter, string? includeProperties = null)
        {
            IQueryable<T> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                { 
                      query = query.Include(includeProp);            
                }
            }
>>>>>>> Stashed changes
            return query.ToList();

        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            dbSet.RemoveRange(entity);
        }
    }


}
