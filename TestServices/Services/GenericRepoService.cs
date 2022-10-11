using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TestDAL.Repositories;

namespace TestServices.Services
{

    public class GenericRepoService<T>: IGenericRepoService<T> where T : class
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepo<T> _genericRepo;
        public GenericRepoService(IMapper mapper, IGenericRepo<T> genericRepo)
        {
            _mapper = mapper;
            _genericRepo = genericRepo;
        }
        public async Task<List<TDTO>> GetAll<TDTO>(string[] includes = null)
        {
            return _mapper.Map<List<TDTO>>(await _genericRepo.FindAll(includes));
        }
        public async Task<bool> Delete<TDTO>(TDTO product)
        {
            var entity = _mapper.Map<T>(product);
            var result = _genericRepo.Delete(entity);
            await _genericRepo.Save();
            return result;
        }
        public async Task<bool> Update<TDTO>(TDTO product)
        {
            var entity = _mapper.Map<T>(product);
            var result = _genericRepo.Update(entity);
            await _genericRepo.Save();
            return result;
        }
        public async Task<T> Create<TDTO>(TDTO product)
        {
            var entity = _mapper.Map<T>(product);
            var newEntity = _genericRepo.Create(entity);
            await _genericRepo.Save();
            return newEntity;
        }

        public async Task<TDTO> Find<TDTO>(Expression<Func<T, bool>> predicate, string[] includes = null)
        {
            return _mapper.Map<TDTO>(await _genericRepo.Find(predicate, includes));
        }
    }
}
