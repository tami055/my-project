using Myproject.repositories.Entities;
using Myproject.repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Mock
{
     public class MockContext:IContext
    {
        public List<Role> Rolls { get; set;}
        public List<Permissions> Permissions { get; set; }
        public List<Claims> Claims { get; set; }
        public MockContext()
        {
            Rolls = new List<Role>();
           Permissions = new List<Permissions>(); 
           Claims = new List<Claims>();


            Rolls.Add(new Role { Id = 1, Name = "principal", Description = "admin with full access" });
            Rolls.Add(new Role { Id = 2, Name = "pupil", Description = "student with limited access" });

            Permissions.Add(new Permissions { Id = 1, Name = "ViewCurrency", Description="see the students" });
            Permissions.Add(new Permissions { Id = 2, Name = "UpdateMark" , Description ="write your mark"});

            Claims.Add(new Claims { Id = 1, RoleId = 1, PermissionId = 1, Policy = EPolicy.Allow });
            Claims.Add(new Claims { Id = 2, RoleId = 1, PermissionId = 2, Policy = EPolicy.Allow });

            Claims.Add(new Claims { Id = 3, RoleId = 2, PermissionId = 1, Policy = EPolicy.Deny });
            Claims.Add(new Claims { Id = 4, RoleId = 2, PermissionId = 2, Policy = EPolicy.Allow });
        }


    }
}
