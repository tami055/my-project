using Myproject.repositories.Entities;
using Myproject.repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.repositories.Repositories
{
    public class ClaimRepository : IClaimRepository
    {
        private readonly IContext _context;
        public ClaimRepository(IContext context)
        {
            _context = context;
        }
        public Claims Add(int id, string name, string description)
        {
            Claims r = new Claims();
            r.Id = id;
            _context.Claims.Add(r);
            return r;
        }

        public void Delete(int id)
        {
            _context.Claims.Remove(_context.Claims.Find(r => r.Id == id));
        }

        public List<Claims> GetAll()
        {
            return _context.Claims;
        }

        public Claims GetById(int id)
        {
            return _context.Claims.Find(r => r.Id == id);
        }

        public Claims Update(Claims role)
        {
            var r1 = _context.Claims.Find(r => r.Id == role.Id);
            r1.Id = role.Id;
            r1.RoleId = role.RoleId;
            r1.PermissionId = role.PermissionId;
          
            return r1;

        }
    }
}
