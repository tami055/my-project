using Microsoft.AspNetCore.Http;
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
    public class RoleController : ControllerBase
    {
        private readonly IRoleRepository _roleRepository;
        public RoleController(IRoleRepository __roleRepository)
        {
           
            _roleRepository = __roleRepository;
        }
        [HttpGet]
        public List<Role> Get()
        {
            return _roleRepository.GetAll();
        }

        [HttpGet("{id}")]
        public Role Get(int id)
        {
            return _roleRepository.GetById(id);
        }

    }
}
