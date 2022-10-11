using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TestServices.Services
{
    public interface IGenericRepoService<T> where T : class
    {
        Task<T> Create<TDTO>(TDTO product);
        Task<bool> Delete<TDTO>(TDTO product);
        Task<List<TDTO>> GetAll<TDTO>(string[] includes = null);
        Task<bool> Update<TDTO>(TDTO product);
        Task<TDTO> Find<TDTO>(Expression<Func<T, bool>> predicate, string[] includes = null);
    }
}
