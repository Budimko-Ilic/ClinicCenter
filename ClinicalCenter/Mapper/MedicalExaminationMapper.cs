using ClinicalCenter.Contracts;
using ClinicalCenter.Entities.Models;
using ClinicalCenter.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalCenter.Mapper
{
    public class MedicalExaminationMapper
    {
        private IRepositoryWrapper _repoWrapper;

        public MedicalExaminationMapper(IRepositoryWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
        }
        public List<MedicalExaminationForUserViewModel> MedicalExaminationToMedicalExaminationForUserViewModel(List<MedicalExamination> medicalExaminationByUser)
        {
            var allMedicalStaffOnExaminations = _repoWrapper.MedicalStaffOnExamination.FindAll().ToList();
            var allStafs = _repoWrapper.Staff.FindAll();
            var allClinics = _repoWrapper.Clinic.FindAll();
            List<ClinicExamination> allClinicExaminations = _repoWrapper.ClinicExamination.FindAll().ToList();
            List<TypeOfMedicalExamination> allTypesOfMedicalExamination = _repoWrapper.TypeOfMedicalExamination.FindAll().ToList();
            List<MedicalExaminationForUserViewModel> result = new List<MedicalExaminationForUserViewModel>();

            result = (from d in medicalExaminationByUser
                      join c in allMedicalStaffOnExaminations on d.MedicalStaffId equals c.Id
                      join s in allStafs on c.MedicalStaffId equals s.Id
                      join a in allClinicExaminations on d.TypeId equals a.Id
                      join e in allClinics on a.ClinicId equals e.Id
                      join b in allTypesOfMedicalExamination on a.TypeOfExaminationId equals b.Id
                      select new MedicalExaminationForUserViewModel
                      {
                          Id = d.Id,
                          LastName = s.LastName,
                          FirstName = s.FirstName,
                          Price = a.Price,
                          ExaminitionName = b.Type,
                          ClinicName = e.Name,
                          DateAndTimeOfStart = d.DateAndTimeOfStart,
                      }).ToList();

            return result;
        }
        public MedicalExamination CreateExamination(ClinicExamination clinicExamination, string dateAndTimeOfStart, string email)
        {

            DateTime myTime = DateTime.Parse(dateAndTimeOfStart);
            MedicalExamination examination = new MedicalExamination();
            List<MedicalStaffOnExamination> medicalStaffsOnExamination = _repoWrapper.MedicalStaffOnExamination.FindAll()
                .Where(x => x.ClinicExaminationId.Equals(clinicExamination.Id)).ToList();
            List<Staff> staffsOnClinic = _repoWrapper.Staff.FindAll().Where(y => y.ClinicId.Equals(clinicExamination.ClinicId)).ToList();
            User user = _repoWrapper.User.GetUserByEmail(email);
            Guid newGuid = Guid.NewGuid();
            examination = (MedicalExamination)(from a in staffsOnClinic
                                               join b in medicalStaffsOnExamination on a.Id equals b.MedicalStaffId
                                               select new MedicalExamination
                                               {
                                                   Id = newGuid,
                                                   TypeId = clinicExamination.Id,
                                                   DiscauntPrice = clinicExamination.Price,
                                                   MedicalStaffId = b.Id,
                                                   UserId = user.Id,
                                                   DateAndTimeOfStart = myTime,
                                                   DateAndTimeOfEnd = myTime.AddMinutes(30)

                                               }).FirstOrDefault();
            return examination;
        }
    }
}
