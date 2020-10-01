using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicalCenter.Entities.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("Role")]
        public Guid RoleId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }

    }
}
