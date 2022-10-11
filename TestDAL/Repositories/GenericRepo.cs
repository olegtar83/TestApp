using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TestDAL.Models;

namespace TestDAL.Repositories
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        private readonly NovoBITestDBContext _context;
        public GenericRepo(NovoBITestDBContext context)
        {
            _context = context;
        }
        public T Create(T entity)
        {

            var result = _context.Set<T>().Add(entity);
            return result.Entity;
        }

        public bool Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            return true;
        }

        public async Task<T> Find(Expression<Func<T, bool>> predicate, string[] includes = null)
        {
            if (includes.Count() != 0)
            {
                var query = _context.Set<T>().Include(includes[0]);
                for (int i = 1; i < includes.Length; i++)
                {
                    query = query.Include(includes[i]);
                }
                return await query.FirstOrDefaultAsync(predicate);
            }
            else
            {
                return await _context.Set<T>().FirstOrDefaultAsync(predicate);
            }
        }

        public async Task<List<T>> FindAll(string[] includes = null)
        {
            if (includes.Count() != 0)
            {
                var query = _context.Set<T>().Include(includes[0]);
                for (int i = 1; i < includes.Length; i ++)
                {
                    query = query.Include(includes[i]);
                }
                return await query.ToListAsync();
            }
            else
            {
                return await _context.Set<T>().ToListAsync();
            }
        }

        public async Task<bool> Save()
        {

            await _context.SaveChangesAsync();
            return true;
        }

        public bool Update(T entity)
        {

            _context.Update(entity);
            return true;
        }
    }
}

