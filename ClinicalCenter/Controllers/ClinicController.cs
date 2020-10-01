using System;
using System.Collections.Generic;
using System.Linq;
using ClinicalCenter.Contracts;
using ClinicalCenter.Entities.Models;
using ClinicalCenter.Entities.ViewModels;
using ClinicalCenter.Mapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinicalCenter.Controllers
{
    public class ClinicController : Controller
    {
        private readonly IRepositoryWrapper _repoWrapper;

        public ClinicController(IRepositoryWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
        }
        [HttpGet]
        [Route("ClinicPage/{id}")]
        public IActionResult ClinicPage()
        {
            string Id = (string)RouteData.Values["Id"];
            Clinic clinic = _repoWrapper.Clinic.GetClinicById(Id);
            return View(clinic);
        }
        [HttpGet]
        [Route("ClinicExamination/{id}")]
        public IActionResult ClinicExamination()
        {
            
            string clinicId = (string)RouteData.Values["Id"];
            
            HttpContext.Session.SetString("Id", clinicId);
            List<ClinicExamination> clinic = _repoWrapper.ClinicExamination.GetClinicExaminationsByClinicId(clinicId);
            var medicalExamination = _repoWrapper.TypeOfMedicalExamination.FindAll().ToList();
            List<ClinicExaminationViewModel> clinicExaminationViewModel = ClinicMapper.UserViewModeToUser(clinic, medicalExamination);
           
            return View(clinicExaminationViewModel);
        }
        [HttpGet]
        [Route("MedicalStaff/{id}")]
        public IActionResult MedicalStaffInClinic()
        {
            string clinicId = (string)RouteData.Values["Id"];
            HttpContext.Session.SetString("Id", clinicId);
            List <Staff> staffInClinic= _repoWrapper.Staff.GetAllStaffInClinic(clinicId);
            List<StaffViewModel> staffViewModels = ClinicMapper.StaffToStaffViewModel(staffInClinic);
            return View(staffViewModels);
        }
        [HttpGet]
        [Route("MedicalExaminationOnDiscount/{id}")]
        public IActionResult MedicalExaminationOnDiscount()
        {
            
            string clinicId = (string)RouteData.Values["Id"];
            HttpContext.Session.SetString("Id", clinicId);
            List<ClinicExamination> clinicExaminations= _repoWrapper.ClinicExamination.GetClinicExaminationsByClinicId(clinicId);
            List<MedicalExamination> medicalExaminationByClinicOnDiscount = _repoWrapper.MedicalExamination.GetMedicalExaminationsByType(clinicExaminations);
           
            ClinicMapper cl = new ClinicMapper(_repoWrapper);
            List<ClinicExaminitionOnDiscountViewModel> result = cl.MedicalExaminationToClinicExaminitionOnDiscountViewModel(medicalExaminationByClinicOnDiscount);
            return View(result);
        }

    }
}
