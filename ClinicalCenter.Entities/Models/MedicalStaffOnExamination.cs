using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicalCenter.Entities.Models
{
    [Table("MedicalStaffOnExamination")]
    public class MedicalStaffOnExamination
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("Staff")]
        public Guid MedicalStaffId { get; set; }
        [ForeignKey("ClinicExamination")]
        public Guid ClinicExaminationId { get; set; }

    }
}
