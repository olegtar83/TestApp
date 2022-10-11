using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TestDAL.Repositories
{
    public interface IGenericRepo<T> where T : class
    {
        T Create (T entity);
        bool Update (T entity);
        bool Delete (T entity);
        Task<T> Find(Expression<Func<T, bool>> predicate, string[] includes = null);
        Task<List<T>> FindAll(string[] includes = null);
        Task<bool> Save();


    }
}
