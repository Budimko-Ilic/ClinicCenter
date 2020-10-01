using ClinicalCenter.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicalCenter.Contracts.ModelInterfaces
{
    public interface IMedicalExaminationRepository : IRepositoryBase<MedicalExamination>
    {
        public List<MedicalExamination> GetMedicalExaminationsByType(List<ClinicExamination> clinicExaminations);
        public MedicalExamination FindMedicalExaminationById(Guid id);
        public MedicalExamination ReservateMedicalExaminitonOnDiscount(MedicalExamination examination, Guid userId);
        public List<MedicalExamination> ActiveUserMedicalExaminations(Guid userId);
        public List<MedicalExamination> UserHistoryOfMedicalExamination(Guid userId);
    }
}
