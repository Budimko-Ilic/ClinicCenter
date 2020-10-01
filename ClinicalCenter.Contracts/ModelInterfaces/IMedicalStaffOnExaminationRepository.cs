using ClinicalCenter.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicalCenter.Contracts.ModelInterfaces
{
    public interface IMedicalStaffOnExaminationRepository : IRepositoryBase<MedicalStaffOnExamination>
    {
        public List<MedicalStaffOnExamination> GetMedicalStaffOnExaminationsByClinicalExaminitionId(Guid clinicalExaminitionId);
    }
}
