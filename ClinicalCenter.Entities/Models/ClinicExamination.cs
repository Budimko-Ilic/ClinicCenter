using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicalCenter.Entities.Models
{
    [Table("ClinicExamination")]
    public class ClinicExamination
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("TypeOfExamination")]
        public Guid TypeOfExaminationId { get; set; }
        [ForeignKey("Clinic")]
        public Guid ClinicId { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
