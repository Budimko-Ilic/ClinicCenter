using ClinicalCenter.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicalCenter.Contracts.ModelInterfaces
{
    public interface IClinicRepository : IRepositoryBase<Clinic>
    {
        public Clinic GetClinicById(string id);
    }
}
