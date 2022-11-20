using Microsoft.AspNetCore.Mvc;
using MyProject.Mockk;
using MyProject.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleRepository _roleRepository;

        public RoleController()
        {
            var mock = new MockContext();
        }
    }
}
