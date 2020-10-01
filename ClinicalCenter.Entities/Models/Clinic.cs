using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicalCenter.Entities.Models
{
    [Table("Clinic")]
    public class Clinic
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
    }
}
