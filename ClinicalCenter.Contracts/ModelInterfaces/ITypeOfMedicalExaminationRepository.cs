using ClinicalCenter.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicalCenter.Contracts.ModelInterfaces
{
    public interface ITypeOfMedicalExaminationRepository : IRepositoryBase<TypeOfMedicalExamination>
    {
        public TypeOfMedicalExamination GetNameOfClinicExamination(ClinicExamination clinicExamination);
        
    }
}
