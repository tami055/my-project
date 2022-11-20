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
    public class PermissionController : Controller
    {
        private readonly IPermissionsRepository _permissionRepository;

        public PermissionController(IPermissionsRepository permission)
        {
          
            _permissionRepository = permission;
        }

        [HttpGet]
        public List<Permissions> Get()
        {
            return _permissionRepository.GetAll();
        }

        [HttpGet("{id}")]
        public Permissions Get(int id)
        {
            return _permissionRepository.GetById(id);
        }
    }
}
