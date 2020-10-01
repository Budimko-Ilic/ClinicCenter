using ClinicalCenter.Contracts;
using ClinicalCenter.Contracts.ModelInterfaces;
using ClinicalCenter.Entities;

namespace ClinicalCenter.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private RepositoryContext _repositoryContext;

        private IUserRepository user;
        private IRoleRepository role;
        private IClinicRepository clinic;
        private IClinicExaminationRepository clinicExamination;
        private ITypeOfMedicalExaminationRepository typeOfMedicalExamination;
        private IStaffRepository staff;
        private IMedicalExaminationRepository medicalExamination;
        private IMedicalStaffOnExaminationRepository medicalStaffOnExamination;
        private IClinicMarkRepository clinicMark;

        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;

        }
        public IUserRepository User
        {
            get
            {
                if (user == null)
                {
                    user = new UserRepository(_repositoryContext);
                }
                return user;
            }
        }
        public IRoleRepository Role
        {
            get
            {
                if (role == null)
                {
                    role = new RoleRepository(_repositoryContext);
                }
                return role;
            }
        }
        public IClinicRepository Clinic
        {
            get
            {
                if (clinic == null)
                {
                    clinic = new ClinicRepository(_repositoryContext);
                }
                return clinic;
            }
        }
        public IClinicExaminationRepository ClinicExamination
        {
            get
            {
                if (clinicExamination == null)
                {
                    clinicExamination = new ClinicExaminationRepository(_repositoryContext);
                }
                return clinicExamination;
            }
        }
        public ITypeOfMedicalExaminationRepository TypeOfMedicalExamination
        {
            get
            {
                if (typeOfMedicalExamination == null)
                {
                    typeOfMedicalExamination = new TypeOfMedicalExaminationRepository(_repositoryContext);
                }
                return typeOfMedicalExamination;
            }
        }
        public IStaffRepository Staff
        {
            get
            {
                if (staff == null)
                {
                    staff = new StaffRepository(_repositoryContext);
                }
                return staff;
            }
        }
        public IMedicalExaminationRepository MedicalExamination
        {
            get
            {
                if (medicalExamination == null)
                {
                    medicalExamination = new MedicalExaminationRepository(_repositoryContext);
                }
                return medicalExamination;
            }
        }
        public IMedicalStaffOnExaminationRepository MedicalStaffOnExamination
        {
            get
            {
                if (medicalStaffOnExamination == null)
                {
                    medicalStaffOnExamination = new MedicalStaffOnExaminationRepository(_repositoryContext);
                }
                return medicalStaffOnExamination;
            }
        }
      
        public IClinicMarkRepository ClinicMark
        {
            get
            {
                if (clinicMark == null)
                {
                    clinicMark = new ClinicMarkRepository(_repositoryContext);
                }
                return clinicMark;
            }
        }

        public void Save()
        {
            _repositoryContext.SaveChanges();
        }
    }
}
