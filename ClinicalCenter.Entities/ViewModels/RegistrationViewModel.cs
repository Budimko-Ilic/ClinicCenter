using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicalCenter.Entities.ViewModels
{
    public class RegistrationViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
    }
}
