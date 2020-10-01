using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicalCenter.Entities.Models
{
    [Table("ClinicMark")]
    public class ClinicMark
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("Clinic")]
        public Guid ClinicId { get; set; }
        [ForeignKey("User")]
        public Guid UserId { get; set; }
        public double Mark { get; set; }
    }
}
