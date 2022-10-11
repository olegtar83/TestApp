using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestDAL.Models;
using TestServices.DTO;
using System.Linq;

namespace TestServices.Services
{
    public class RepoServices: IRepoServices
    {
        private readonly IMapper _mapper;
 
        public RepoServices(IMapper mapper
            )
        {
            _mapper = mapper;

        }
     
    }
}
