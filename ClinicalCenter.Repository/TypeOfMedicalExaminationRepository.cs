using ClinicalCenter.Contracts.ModelInterfaces;
using ClinicalCenter.Entities;
using ClinicalCenter.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicalCenter.Repository
{
    public class TypeOfMedicalExaminationRepository : RepositoryBase<TypeOfMedicalExamination>, ITypeOfMedicalExaminationRepository
    {
        public TypeOfMedicalExaminationRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }

        public TypeOfMedicalExamination GetNameOfClinicExamination(ClinicExamination ClinicExamination)
        {
            return FindAll().Where(x => x.Id.Equals(ClinicExamination.TypeOfExaminationId)).FirstOrDefault();
        }
    }
}
