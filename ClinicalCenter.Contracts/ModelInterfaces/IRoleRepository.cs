using ClinicalCenter.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicalCenter.Contracts.ModelInterfaces
{
    public interface IRoleRepository : IRepositoryBase<Role>
    {
        public string GetRole(string role);
    }
}
