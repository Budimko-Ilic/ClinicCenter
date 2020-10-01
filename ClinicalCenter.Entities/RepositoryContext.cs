using ClinicalCenter.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicalCenter.Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<ClinicExamination> ClinicExaminations { get; set; }
        public DbSet<ClinicMark> ClinicMark { get; set; }
        public DbSet<MedicalExamination> MedicalExaminations { get; set; }
        public DbSet<MedicalStaffOnExamination> MedicalStaffOnExaminations { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<TypeOfMedicalExamination> TypeOfMedicalExaminations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Vacation> Vacation { get; set; }
    }
}
