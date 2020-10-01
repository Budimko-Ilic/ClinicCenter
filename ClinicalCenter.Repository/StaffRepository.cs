using ClinicalCenter.Contracts.ModelInterfaces;
using ClinicalCenter.Entities;
using ClinicalCenter.Entities.Models;
using ClinicalCenter.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicalCenter.Repository
{
    public class StaffRepository : RepositoryBase<Staff>, IStaffRepository
    {
        public StaffRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }

        public List<Staff> GetAllStaffInClinic(string clinicId)
        {
            Guid ClinicId = new Guid(clinicId);
            List<Staff> staffInClinic = FindAll().Where(i => i.ClinicId.Equals(ClinicId)).ToList();
            return staffInClinic;
        }
    }
}
