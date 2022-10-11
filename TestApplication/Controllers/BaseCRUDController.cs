using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestDAL.Interfaces;
using TestServices.DTO;
using TestServices.Services;

namespace TestApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseCRUDController<TEntity, TDTO> : ControllerBase 
        where TEntity : class,IBaseModel
        where TDTO : class
    {
        private readonly IGenericRepoService<TEntity> _genericRepoService;
        private readonly IMapper _mapper;
        private readonly string[] _includes;

        public BaseCRUDController(
            IGenericRepoService<TEntity> genericRepoService,
            string[] includes,
            IMapper mapper)
        {
            _includes = includes;
            _genericRepoService = genericRepoService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TDTO>>> GetProducts()
        {
            try
            {
                var products = _mapper.Map<List<TDTO>>(await _genericRepoService.GetAll<TEntity>(_includes));
                return new OkObjectResult(products);
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    code = 400,
                    title = ex.Message
                });
            }
        }

        [HttpGet("[action]/{Id}")]
        public async Task<ActionResult<BookDTO>> Get(int Id)
        {
            try
            {
                var book = await _genericRepoService.Find<TDTO>(x => x.Id == Id );
                return new OkObjectResult(book);
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    code = 400,
                    title = ex.Message
                });
            }
        }

        [HttpPost]
        public async Task<ActionResult<TDTO>> Create(TDTO model)
        {
            try
            {
                var newBook = await _genericRepoService.Create(model);
                return new OkObjectResult(_mapper.Map<TDTO>(newBook));
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    code = 400,
                    title = ex.Message
                });
            }
        }

        [HttpPut]
        public async Task<ActionResult<bool>> Update(TDTO model)
        {
            try
            {
                var result = await _genericRepoService.Update(model);
                return new OkObjectResult(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    code = 400,
                    title = ex.Message
                });
            }
        }

        [HttpDelete]
        public async Task<ActionResult<bool>> Delete(TDTO model)
        {
            try
            {
                var result = await _genericRepoService.Delete(model);
                return new OkObjectResult(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    code = 400,
                    title = ex.Message
                });
            }
        }
    }
}
