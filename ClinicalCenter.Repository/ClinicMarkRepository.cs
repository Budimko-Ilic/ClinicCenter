using ClinicalCenter.Contracts.ModelInterfaces;
using ClinicalCenter.Entities;
using ClinicalCenter.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicalCenter.Repository
{
    public class ClinicMarkRepository : RepositoryBase<ClinicMark>, IClinicMarkRepository
    {
        public ClinicMarkRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }
    }
}
