using ClinicalCenter.Contracts.ModelInterfaces;
using ClinicalCenter.Entities;
using ClinicalCenter.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicalCenter.Repository
{
    public class RoleRepository : RepositoryBase<Role>, IRoleRepository
    {
        public RoleRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
            
        }
        public string GetRole(string role)
        {
            Guid RoleId = new Guid(role);
            return FindAll().Where(x => x.Id.Equals(RoleId)).Select(x => x.Type).FirstOrDefault().ToString();
        }

    }
}
