using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicalCenter.Entities.Models
{
    [Table("Vacation")]
    public class Vacation
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("Staff")]
        public Guid MedicalStaffId { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
    }
}
