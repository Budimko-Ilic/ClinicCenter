using ClinicalCenter.Entities.Models;
using ClinicalCenter.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicalCenter.Contracts.ModelInterfaces
{
    public interface IStaffRepository : IRepositoryBase<Staff>
    {
        public List<Staff> GetAllStaffInClinic(string clinicId);
    }
}
