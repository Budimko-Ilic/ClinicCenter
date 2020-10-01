using ClinicalCenter.Contracts.ModelInterfaces;
using ClinicalCenter.Entities;
using ClinicalCenter.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicalCenter.Repository
{
    public class MedicalExaminationRepository : RepositoryBase<MedicalExamination>, IMedicalExaminationRepository
    {
        public MedicalExaminationRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }

        public List<MedicalExamination> GetMedicalExaminationsByType(List<ClinicExamination> clinicExaminations)
        {
            var medicalExaminations = FindAll().ToList();
            List <MedicalExamination> medicalExaminationByClinic = medicalExaminations.Where(b => clinicExaminations.Any(a => a.Id.Equals(b.TypeId))).ToList();
            List<MedicalExamination> medicalExaminationByClinicOnDiscount = medicalExaminationByClinic.Where(a => a.UserId == null).ToList();
            return medicalExaminationByClinicOnDiscount;
        }
        public MedicalExamination FindMedicalExaminationById(Guid id)
        {
            MedicalExamination examination = FindAll().Where(x => x.Id.Equals(id)).FirstOrDefault();
            return examination;
        }

        public MedicalExamination ReservateMedicalExaminitonOnDiscount(MedicalExamination examination, Guid userId)
        {
           examination.UserId = userId;
           return examination;
        }

        public List<MedicalExamination> ActiveUserMedicalExaminations(Guid userId)
        {
            DateTime curentTime = DateTime.Now;
            List<MedicalExamination> userMedicalExaminations = FindAll().Where(x => x.UserId.Equals(userId) && x.DateAndTimeOfEnd > curentTime).ToList();
            return userMedicalExaminations;
        }

        public List<MedicalExamination> UserHistoryOfMedicalExamination(Guid userId)
        {
            DateTime curentTime = DateTime.Now;
            List<MedicalExamination> userMedicalExaminations = FindAll().Where(x => x.UserId.Equals(userId) && x.DateAndTimeOfEnd < curentTime).ToList();
            return userMedicalExaminations;
        }
    }
}
