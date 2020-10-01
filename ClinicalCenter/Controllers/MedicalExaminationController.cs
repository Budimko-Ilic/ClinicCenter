using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicalCenter.Contracts;
using ClinicalCenter.Entities.Models;
using ClinicalCenter.Mapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinicalCenter.Controllers
{
    public class MedicalExaminationController : Controller
    {
        private readonly IRepositoryWrapper _repoWrapper;

        public MedicalExaminationController(IRepositoryWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
        }
        [HttpGet]
        [Route("CreateMedicalExaminition/{id}")]
        public IActionResult CreateMedicalExaminition()
        {
            string clinicalExaminitionId = (string)RouteData.Values["Id"];
            Guid Id = new Guid(clinicalExaminitionId);
            ClinicExamination examination = _repoWrapper.ClinicExamination.GetClinicExaminationById(Id);
            TypeOfMedicalExamination typeOfMedicalExamination = _repoWrapper.TypeOfMedicalExamination.GetNameOfClinicExamination(examination);
            return View(typeOfMedicalExamination);
        }
        [HttpPost]
        [Route("CreateMedicalExaminition/{id}")]
        public IActionResult CreateMedicalExaminition(string date)
        {
            string clinicalExaminitionId = (string)RouteData.Values["Id"];
            Guid Id = new Guid(clinicalExaminitionId);
            ClinicExamination examination = _repoWrapper.ClinicExamination.GetClinicExaminationById(Id);
            MedicalExaminationMapper mapper = new MedicalExaminationMapper(_repoWrapper);
            string email = HttpContext.Session.GetString("User");
            MedicalExamination medicalExamination = mapper.CreateExamination(examination, date, email);
            _repoWrapper.MedicalExamination.Create(medicalExamination);
            _repoWrapper.Save();

            return RedirectToAction("UserPage", "User");
        }
        [HttpGet]
        [Route("Delete/{id}")]
        public IActionResult DeleteMedicalExamination()
        {
            string id = (string)RouteData.Values["Id"];
            Guid userId = new Guid(id);
            _repoWrapper.MedicalExamination.Delete(userId);
            _repoWrapper.Save();
            return RedirectToAction("ActiveMedicalExamination", "User");
        }
    }
}
