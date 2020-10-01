using ClinicalCenter.Contracts.ModelInterfaces;
using ClinicalCenter.Entities;
using ClinicalCenter.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicalCenter.Repository
{
    public class ClinicExaminationRepository : RepositoryBase<ClinicExamination>, IClinicExaminationRepository
    {
        public ClinicExaminationRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }

        public ClinicExamination GetClinicExaminationById(Guid Id)
        {
            ClinicExamination examination = FindAll().Where(x => x.Id.Equals(Id)).FirstOrDefault();
            return examination;
        }

        public List<ClinicExamination> GetClinicExaminationsByClinicId(string ClinicId)
        {
            Guid clinicId = new Guid(ClinicId);
            List<ClinicExamination> clinicExaminationsBy = FindAll().Where(ci => ci.ClinicId.Equals(clinicId)).ToList();

            return clinicExaminationsBy;
        }
    }
}
