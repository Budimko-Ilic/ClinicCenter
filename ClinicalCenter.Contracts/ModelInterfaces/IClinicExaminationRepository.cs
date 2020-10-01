using ClinicalCenter.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicalCenter.Contracts.ModelInterfaces
{
    public interface IClinicExaminationRepository : IRepositoryBase<ClinicExamination>
    {
        public List<ClinicExamination> GetClinicExaminationsByClinicId(string clinicId);
        public ClinicExamination GetClinicExaminationById(Guid id);
    }
}
