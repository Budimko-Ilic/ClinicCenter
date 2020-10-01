using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicalCenter.Entities.ViewModels
{
    public class StaffViewModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public TimeSpan ShiftStart { get; set; }
        public TimeSpan ShiftEnd { get; set; }
        public string Info { get; set; }
    }
}
