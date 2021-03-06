using System.Collections.Generic;
using System.Threading.Tasks;
using API.Specifications;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
         Task<T> GetByIdAsync(int id);
         Task<IReadOnlyList<T>> ListAllAsync();
        Task<T> GetEntityWithSpec(ISpecifications<T> spec);
         Task<IReadOnlyList<T>> ListAsync(ISpecifications<T> spec);
    }
}