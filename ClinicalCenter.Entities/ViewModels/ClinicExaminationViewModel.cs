using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicalCenter.Entities.ViewModels
{
    public class ClinicExaminationViewModel
    {
        public Guid Id { get; set; }
        public string NameOfMedicalExamination { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
    }
}
