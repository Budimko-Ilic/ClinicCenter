using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicalCenter.Entities.Models
{
    [Table("Staff")]
    public class Staff
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("Role")]
        public Guid RoleId { get; set; }
        [ForeignKey("Clinic")]
        public Guid ClinicId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public TimeSpan ShiftStart { get; set; }
        public TimeSpan ShiftEnd { get; set; }
        public string Info { get; set; }
    }
}
