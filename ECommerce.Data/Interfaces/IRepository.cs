using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerce.Data.Interfaces
{
    public interface IRepository<T> where T : class
    {
        T Insert(T entity);
        T Update(T entity);
        void Purge(int id);
        IEnumerable<T> List();
        IQueryable<T> Query();
        T Get(int id);
    }
}
