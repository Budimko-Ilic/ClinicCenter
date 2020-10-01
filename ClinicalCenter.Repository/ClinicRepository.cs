using ClinicalCenter.Contracts.ModelInterfaces;
using ClinicalCenter.Entities;
using ClinicalCenter.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicalCenter.Repository
{
    public class ClinicRepository : RepositoryBase<Clinic>, IClinicRepository
    {
        public ClinicRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }
        public Clinic GetClinicById(string Id)
        {
            Guid clinicId = new Guid(Id);
            Clinic clinic = FindAll().Where(x => x.Id.Equals(clinicId)).FirstOrDefault();
            return clinic;
        }
    }
}
