using Myproject.repositories.Entities;
using Myproject.repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.repositories.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly IContext _context;
        public RoleRepository(IContext context)
        {
            _context = context;
        }
        public Role Add(int id, string name, string description)
        {
            Role r = new Role();
            r.Id = id;
            r.Name = name;
            r.Description = description;
            _context.Rolls.Add(r);
            return r;
        }

        public void Delete(int id)
        {

            _context.Rolls.Remove(_context.Rolls.Find(r => r.Id == id));
        }

        public List<Role> GetAll()
        {
            return _context.Rolls;
        }

        public Role GetById(int id)
        {
            return _context.Rolls.Find(r => r.Id == id);
        }

        public Role Update(Role role)
        {
            var r1 = _context.Rolls.Find(r => r.Id == role.Id);
            r1.Name = role.Name;
            r1.Description = role.Description;
            return r1;


        }
    }
}
