using ClinicalCenter.Entities.Models;
using ClinicalCenter.Entities.ViewModels;
using System;
using System.Linq;

namespace ClinicalCenter.Contracts.ModelInterfaces
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        bool UserAlreadyExist(string email);
        public bool UserExist(LoginViewModel login);
        public string Role(LoginViewModel login);
        public UserInfoViewModel GetUserInfo(string email);
        public User GetUserByEmail(string email);
        public Guid FindUserIdByEmail(string email);

    }
}
