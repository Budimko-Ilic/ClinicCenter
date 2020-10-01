using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicalCenter.Entities.ViewModels
{
    public class ClinicExaminitionOnDiscountViewModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ExaminitionName { get; set; }
        public decimal OldPrice { get; set; }
        public decimal NewPrice { get; set; }
        public DateTime DateAndTimeOfStart { get; set; }
        public DateTime DateAndTimeOfEnd { get; set; }
    }
}
