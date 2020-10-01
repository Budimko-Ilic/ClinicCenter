using ClinicalCenter.Contracts;
using ClinicalCenter.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace ClinicalCenter.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected RepositoryContext RepositoryContext { get; set; }
        public RepositoryBase(RepositoryContext repositoryContext)
        {
            RepositoryContext = repositoryContext;
        }
        public void Create(T entity)
        {
            RepositoryContext.Set<T>().Add(entity);
        }

        public void Delete(Guid Id)
        {
            T entityToDelete = RepositoryContext.Set<T>().Find(Id);
            RepositoryContext.Remove(entityToDelete);
        }

        public IQueryable<T> FindAll()
        {
            return RepositoryContext.Set<T>().AsNoTracking();
        }

        
        public void Update(T entity)
        {
            RepositoryContext.Set<T>().Update(entity);
        }
    }
}
