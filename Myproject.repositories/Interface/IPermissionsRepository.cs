using Myproject.repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.repositories.Interface
{
    public interface IPermissionsRepository
    {
        List<Permissions> GetAll();

        Permissions GetById(int id);

        Permissions Add(int id, string name, string description);

        Permissions Update(Permissions role);

        void Delete(int id);
    }
}
