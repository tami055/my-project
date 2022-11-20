using Myproject.repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.repositories.Interface
{
    public interface IClaimRepository
    {
        List<Claims> GetAll();

        Claims GetById(int id);

        Claims Add(int id, string name, string description);

        Claims Update(Claims role);

        void Delete(int id);
    }
}
