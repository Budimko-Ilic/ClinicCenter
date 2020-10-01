using ClinicalCenter.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalCenter.Mapper
{
    public class MarkMapper
    {
        public static ClinicMark ClinicmMarkMapper(ClinicExamination clinicExamination, double mark, Guid userId)
        {
            Guid id = Guid.NewGuid();
            ClinicMark clinicMark = new ClinicMark();
            clinicMark.Id = id;
            clinicMark.Mark = mark;
            clinicMark.ClinicId = clinicExamination.ClinicId;
            clinicMark.UserId = userId;
            return clinicMark;
        }
    }
}
