﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ecclesia.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        //T - Category
<<<<<<< Updated upstream
        IEnumerable<T> GetAll();
        T Get(Expression <Func<T, bool>> filter);
=======
        IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter=null,string? includeProperties = null);
        T Get(Expression <Func<T, bool>> filter, string? includeProperties = null, bool tracked =false);
>>>>>>> Stashed changes
        void Add(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);
    }
}
