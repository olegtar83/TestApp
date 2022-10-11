using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestDAL.Models;
using TestServices.DTO;
using TestServices.Services;

namespace TestApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : BaseCRUDController<Books, BookDTO>
    {
        private readonly string[] includes;

        public BooksController(IGenericRepoService<Books> genericRepoService, string[] includes, IMapper mapper) : base(genericRepoService, new string[] {"BookType"}, mapper)
        {
            this.includes = includes;
        }
    }
}
