using ClinicalCenter.Contracts;
using ClinicalCenter.Entities.Models;
using ClinicalCenter.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalCenter.Mapper
{
    public class ClinicMapper
    {
        private IRepositoryWrapper _repoWrapper;

        public ClinicMapper(IRepositoryWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
        }

        public static List<ClinicExaminationViewModel> UserViewModeToUser(List<ClinicExamination> clinics, List<TypeOfMedicalExamination> typeOfMedicalExamination)
        {
            List<ClinicExaminationViewModel> clinicViewModels = new List<ClinicExaminationViewModel>();

            clinics.ForEach(t => clinicViewModels.Add(new ClinicExaminationViewModel()
            {   Id = t.Id,             
                NameOfMedicalExamination = typeOfMedicalExamination.FirstOrDefault(i => i.Id.Equals(t.TypeOfExaminationId)).Type,
                Price = (double)t.Price,
                Description = t.Description
            }));
            return clinicViewModels;
        }
        public static List<StaffViewModel> StaffToStaffViewModel(List<Staff> staffs) 
        {
            List<StaffViewModel> staffViewModel = new List<StaffViewModel>();
            staffs.ForEach(t => staffViewModel.Add(new StaffViewModel()
            {
                Id = t.Id,
                FirstName = t.FirstName,
                LastName = t.LastName,
                Email = t.Email,
                ShiftStart = t.ShiftStart,
                ShiftEnd = t.ShiftEnd,
                Info = t.Info
            }));
            return staffViewModel;
        }
        public List<ClinicExaminitionOnDiscountViewModel> MedicalExaminationToClinicExaminitionOnDiscountViewModel(List<MedicalExamination> medicalExaminationByClinicOnDiscount) 
        {
            var allMedicalStaffOnExaminations = _repoWrapper.MedicalStaffOnExamination.FindAll().ToList();
            var allStafs = _repoWrapper.Staff.FindAll();
            List<ClinicExamination> allClinicExaminations = _repoWrapper.ClinicExamination.FindAll().ToList();
            List<TypeOfMedicalExamination> allTypesOfMedicalExamination = _repoWrapper.TypeOfMedicalExamination.FindAll().ToList();
            List<ClinicExaminitionOnDiscountViewModel> result = new List<ClinicExaminitionOnDiscountViewModel>();

            result = (from d in medicalExaminationByClinicOnDiscount
                       join c in allMedicalStaffOnExaminations on d.MedicalStaffId equals c.Id
                       join s in allStafs on c.MedicalStaffId equals s.Id
                       join a in allClinicExaminations on d.TypeId equals a.Id
                       join b in allTypesOfMedicalExamination on a.TypeOfExaminationId equals b.Id
                       select new ClinicExaminitionOnDiscountViewModel
                       {
                           Id = d.Id,
                           LastName = s.LastName,
                           FirstName = s.FirstName,
                           OldPrice = a.Price,
                           NewPrice = d.DiscauntPrice,
                           DateAndTimeOfStart = d.DateAndTimeOfStart,
                           DateAndTimeOfEnd = d.DateAndTimeOfEnd,
                           ExaminitionName = b.Type,
                       }).ToList();
            
            return result;
        }

    }
}
