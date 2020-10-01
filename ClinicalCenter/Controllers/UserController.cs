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
    public class UserController : Controller
    {
        private readonly IRepositoryWrapper _repoWrapper;

        public UserController(IRepositoryWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
        }
        [HttpGet]
        [Route("UserPage")]
        public IActionResult UserPage()
        {  

            UserInfoViewModel user = _repoWrapper.User.GetUserInfo(HttpContext.Session.GetString("User"));
            return View(user);
        }
        [HttpPost]
        [Route("UserPage")]
        public IActionResult UserPage(UpdateUser updateUser)
        {
            User user = _repoWrapper.User.GetUserByEmail(updateUser.Email);
            User updateuser = UserMapper.UserInfoViewModelToUser(updateUser, user);
            _repoWrapper.User.Update(updateuser);
            _repoWrapper.Save();
            UserInfoViewModel userInfo = _repoWrapper.User.GetUserInfo(HttpContext.Session.GetString("User"));
            return View(userInfo);
        }
        [HttpGet]
        [Route("HealthCard")]
        public IActionResult HealthCard()
        {
            Guid userId = _repoWrapper.User.FindUserIdByEmail(HttpContext.Session.GetString("User"));
            List<MedicalExamination> history = _repoWrapper.MedicalExamination.UserHistoryOfMedicalExamination(userId);
            MedicalExaminationMapper mapper = new MedicalExaminationMapper(_repoWrapper);
            List<MedicalExaminationForUserViewModel> historyViewModel = mapper.MedicalExaminationToMedicalExaminationForUserViewModel(history);

            var tupleData = new Tuple<List<MedicalExaminationForUserViewModel>>(historyViewModel);
            return View(tupleData);
        }
        [HttpGet]
        [Route("ActiveMedicalExamination")]
        public IActionResult ActiveMedicalExamination()
        {
            Guid userId = _repoWrapper.User.FindUserIdByEmail(HttpContext.Session.GetString("User"));
            List<MedicalExamination> allUserActiveExaminitions = _repoWrapper.MedicalExamination.ActiveUserMedicalExaminations(userId);
            MedicalExaminationMapper mapper = new MedicalExaminationMapper(_repoWrapper);
            List<MedicalExaminationForUserViewModel> result = mapper.MedicalExaminationToMedicalExaminationForUserViewModel(allUserActiveExaminitions);
            return View(result);
        }

        [HttpPost]
        [Route("ActiveMedicalExamination")]
        public IActionResult ReservateMedicalExaminitonOnDiscount(Guid Id)
        {
            MedicalExamination examination = _repoWrapper.MedicalExamination.FindMedicalExaminationById(Id);
            Guid userId = _repoWrapper.User.FindUserIdByEmail(HttpContext.Session.GetString("User"));
            MedicalExamination result = _repoWrapper.MedicalExamination.ReservateMedicalExaminitonOnDiscount(examination,userId);
            _repoWrapper.MedicalExamination.Update(result);
            _repoWrapper.Save();

            return View();
        }

        [HttpGet]
        [Route("ListOfClinics")]
        public IActionResult ListOfClinics()
        {
            List<Clinic> Clinic = (List<Clinic>)_repoWrapper.Clinic.FindAll().ToList();
            return View(Clinic);
        }


    }
}
