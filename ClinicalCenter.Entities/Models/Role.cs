using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicalCenter.Entities.Models
{
    [Table("Role")]
    public class Role
    {
        [Key]
        public Guid Id { get; set; }
        public string Type { get; set; }
    }
}
