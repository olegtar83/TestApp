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
    public class DiscsController : BaseCRUDController<Discs, DiscDTO>
    {
        private readonly string[] includes;

        public DiscsController(IGenericRepoService<Discs> genericRepoService, string[] includes, IMapper mapper) : base(genericRepoService, new string[] { "DiscContent", "DiscType" }, mapper)
        {
            this.includes = includes;
        }
    }
}
