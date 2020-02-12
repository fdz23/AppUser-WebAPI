using AppUser.Domain;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;

namespace AppUser.Data
{
    public interface IRepository <T> where T : BaseEntity
    {
         Task<T> Create(T entity);
         Task<T> ResearchID(Guid id);
         Task<IEnumerable<T>> ResearchAll();
         Task<T> Update(T entity);
         Task<bool> Delete(Guid id);
         Task<bool> Exists(Guid id);
    }
}