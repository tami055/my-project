using Myproject.repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.repositories.Interface
{
    public interface IContext
    {
        List<Role> Rolls { get; set; }

        List<Permissions> Permissions { get; set; }

        List<Claims> Claims { get; set; }
    }
}
