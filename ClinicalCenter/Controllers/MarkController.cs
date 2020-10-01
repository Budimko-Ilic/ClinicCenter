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
    public class MarkController : Controller
    {
        private readonly IRepositoryWrapper _repoWrapper;

        public MarkController(IRepositoryWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
        }
        [HttpGet]
        [Route("MarkExamination/{id}")]
        public IActionResult MarkExamination()
        {
            return View();
        }
        [HttpPost]
        [Route("MarkExamination/{id}")]
        public IActionResult MarkExamination(double clinicMark)
        {
            string medicalExaminationId = (string)RouteData.Values["Id"];
            Guid Id = new Guid(medicalExaminationId);

            MedicalExamination medicalExamination = _repoWrapper.MedicalExamination.FindMedicalExaminationById(Id);
            ClinicExamination clinic=_repoWrapper.ClinicExamination.GetClinicExaminationById(medicalExamination.TypeId);
            string Email = HttpContext.Session.GetString("User");
            Guid userId =_repoWrapper.User.FindUserIdByEmail(Email);
            ClinicMark ClinicMark = MarkMapper.ClinicmMarkMapper(clinic, clinicMark, userId);

            _repoWrapper.ClinicMark.Create(ClinicMark);
            _repoWrapper.Save();
            return View();
        }
    }
}
