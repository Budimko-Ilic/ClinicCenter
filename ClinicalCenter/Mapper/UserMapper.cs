using ClinicalCenter.Entities.Models;
using ClinicalCenter.Entities.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalCenter.Mapper
{
    public class UserMapper
    {
        public static User UserViewModeToUser(RegistrationViewModel registrationViewModel)
        {
            Guid Id = Guid.NewGuid();
            User user = new User();
            user.Id = Id;
            user.FirstName = registrationViewModel.FirstName;
            user.LastName = registrationViewModel.LastName;
            user.Email = registrationViewModel.Email;
            user.Password = registrationViewModel.Password;
            user.City = registrationViewModel.City;
            user.PhoneNumber = registrationViewModel.PhoneNumber;
            user.RoleId = new Guid("4c3b8ad6-42a4-461a-95e6-9a0efcd41226");
            return user;
        }
        public static User UserInfoViewModelToUser(UpdateUser updateUser, User user) 
        {
            user.City = updateUser.City;
            user.PhoneNumber = updateUser.PhoneNumber;
            return user;
        }
        
       
    }
}
