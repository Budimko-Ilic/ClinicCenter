using ClinicalCenter.Contracts.ModelInterfaces;
using ClinicalCenter.Entities;
using ClinicalCenter.Entities.Models;
using ClinicalCenter.Entities.ViewModels;
using System;
using System.Linq;

namespace ClinicalCenter.Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }
        public bool UserAlreadyExist(string email)
        {
            return FindAll().Where(x => x.Email.Equals(email)).Any();
        }
        public bool UserExist(LoginViewModel login)
        {
            return FindAll().Where(x => x.Email.Equals(login.Email) && x.Password.Equals(login.Password)).Any();
        }
        public string Role(LoginViewModel login)
        {
            var user = FindAll().Where(x => x.Email.Equals(login.Email)).ToList();
            return user.Select(r => r.RoleId).FirstOrDefault().ToString();
        }
        public UserInfoViewModel GetUserInfo(string Email)
        {
            UserInfoViewModel userInfo = new UserInfoViewModel();
            var user = FindAll().Where(x => x.Email.Equals(Email)).ToList();
            userInfo.Email = Email;
            userInfo.City = user.Select(x => x.City).FirstOrDefault().ToString();
            userInfo.FirstName = user.Select(x => x.FirstName).FirstOrDefault().ToString();
            userInfo.LastName = user.Select(c => c.LastName).FirstOrDefault().ToString();
            userInfo.PhoneNumber = user.Select(c => c.PhoneNumber).FirstOrDefault().ToString();

            return userInfo;
        }
        public User GetUserByEmail(string Email)
        {
            User user = FindAll().Where(x => x.Email.Equals(Email)).FirstOrDefault();
            return user;
        }

        public Guid FindUserIdByEmail(string email)
        {
            User user = FindAll().Where(x => x.Email.Equals(email)).FirstOrDefault();
            Guid id = user.Id;
            return id;
        }
    }
}
