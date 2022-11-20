using Myproject.repositories.Entities;
using Myproject.repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.repositories.Repositories
{
    public class PermissionRepository : IPermissionsRepository
    {
        private readonly IContext _context;
        public PermissionRepository(IContext context)
        {
            _context = context;
        }
        public Permissions Add(int id, string name, string description)
        {
            Permissions r = new Permissions();
            r.Id = id;
            r.Name = name;
            r.Description = description;
            _context.Permissions.Add(r);
            return r;
        }

        public void Delete(int id)
        {
            _context.Permissions.Remove(_context.Permissions.Find(r => r.Id == id));
        }

        public List<Permissions> GetAll()
        {
            return _context.Permissions;
        }

        public Permissions GetById(int id)
        {
            return _context.Permissions.Find(r => r.Id == id);
        }

        public Permissions Update(Permissions p)
        { 
            var r1 = _context.Permissions.Find(r => r.Id == p.Id);
            r1.Name = p.Name;
             r1.Id = p.Id;
            r1.Description = p.Description;
            return r1;

        }
    }
}
