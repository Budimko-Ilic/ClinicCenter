using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicalCenter.Entities.ViewModels
{
    public class MedicalExaminationForUserViewModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ExaminitionName { get; set; }
        public string ClinicName { get; set; }
        public decimal Price { get; set; }
        public DateTime DateAndTimeOfStart { get; set; }
    }
}
