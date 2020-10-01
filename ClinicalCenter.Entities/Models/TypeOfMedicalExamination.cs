using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicalCenter.Entities.Models
{
    [Table("TypeOfMedicalExamination")]
    public class TypeOfMedicalExamination
    {
        [Key]
        public Guid Id { get; set; }
        public string Type { get; set; }
    }
}
