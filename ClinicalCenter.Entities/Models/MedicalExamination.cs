using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicalCenter.Entities.Models
{
    [Table("MedicalExamination")]
    public class MedicalExamination
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("User")]
        public Guid? UserId { get; set; }
        [ForeignKey("ClinicExamination")]
        public Guid TypeId { get; set; }
        [ForeignKey("MedicalStaffOnExamination")]
        public Guid MedicalStaffId { get; set; }
        public DateTime DateAndTimeOfStart { get; set; }
        public DateTime DateAndTimeOfEnd { get; set; }
        public decimal DiscauntPrice { get; set; }
    }
}
