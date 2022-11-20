using Microsoft.AspNetCore.Mvc;
using Myproject.repositories.Entities;
using Myproject.repositories.Interface;
using Myproject.repositories.Repositories;
using MyProject.Mock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Myproject.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimController : Controller
    {
        private readonly IClaimRepository _claimRepository;

        public ClaimController(IClaimRepository _claimrepository)
        {
       
            _claimRepository = _claimrepository;
        }

        [HttpGet]
        public List<Claims> Get()
        {
            return _claimRepository.GetAll();
        }

        [HttpGet("{id}")]
        public Claims Get(int id)
        {
            return _claimRepository.GetById(id);
        }
    }
}
