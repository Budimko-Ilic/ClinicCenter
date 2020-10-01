using ClinicalCenter.Contracts.ModelInterfaces;

namespace ClinicalCenter.Contracts
{
    public interface IRepositoryWrapper
    {
        IUserRepository User { get; }
        IRoleRepository Role { get; }
        IClinicRepository Clinic { get; }
        IClinicExaminationRepository ClinicExamination { get; }
        ITypeOfMedicalExaminationRepository TypeOfMedicalExamination { get; }
        IStaffRepository Staff { get; }
        IMedicalExaminationRepository MedicalExamination { get; }
        IMedicalStaffOnExaminationRepository MedicalStaffOnExamination { get; }
        IClinicMarkRepository ClinicMark { get; }
        void Save();
    }
}
