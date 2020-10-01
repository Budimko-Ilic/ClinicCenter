using ClinicalCenter.Contracts.ModelInterfaces;
using ClinicalCenter.Entities;
using ClinicalCenter.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicalCenter.Repository
{
    public class MedicalStaffOnExaminationRepository : RepositoryBase<MedicalStaffOnExamination>, IMedicalStaffOnExaminationRepository
    {
        public MedicalStaffOnExaminationRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }

        public List<MedicalStaffOnExamination> GetMedicalStaffOnExaminationsByClinicalExaminitionId(Guid ClinicalExaminitionId)
        {
            List <MedicalStaffOnExamination> allMedicalStaffonExaminition= FindAll().Where(x => x.ClinicExaminationId.Equals(ClinicalExaminitionId)).ToList();
            return allMedicalStaffonExaminition;
        }
    }
}
