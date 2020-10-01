using ClinicalCenter.Contracts;
using ClinicalCenter.Entities.Models;
using ClinicalCenter.Entities.ViewModels;
using ClinicalCenter.Mapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinicalCenter.Controllers
{
    public class AccountController : Controller
    {
        private readonly IRepositoryWrapper _repoWrapper;

        public AccountController(IRepositoryWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
        }
        [HttpGet]
        [Route("Registration")]
        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        [Route("Registration")]
        public IActionResult Registration(RegistrationViewModel registration)
        {
            if (_repoWrapper.User.UserAlreadyExist(registration.Email))
                return View();
            User user = UserMapper.UserViewModeToUser(registration);
            _repoWrapper.User.Create(user);
            _repoWrapper.Save();
            return View();
        }
        [HttpGet]
        [Route("Login")]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [Route("Login")]
        public IActionResult Login(LoginViewModel login)
        {
            if (_repoWrapper.User.UserExist(login))
            {
                string role = _repoWrapper.Role.GetRole(_repoWrapper.User.Role(login));
                HttpContext.Session.SetString("Role", role);
                HttpContext.Session.SetString("User", login.Email);
                return Redirect("UserPage");
            }
            return View();
        }
    }
}
