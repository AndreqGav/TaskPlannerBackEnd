using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskPlanner.Services.Services
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        Task<Guid> AddAsync<TDtoEntity>(TDtoEntity item);
        Task<IEnumerable<Guid>> AddAsync<TDtoEntity>(IEnumerable<TDtoEntity> items);
        ValueTask UpdateAsync<TDtoEntity>(TDtoEntity item);
        ValueTask UpdateAsync<TDtoEntity>(Guid id, TEntity patchData);
        ValueTask DeleteAsync(Guid id);
        Task<TDtoEntity> GetByIdAsync<TDtoEntity>(Guid id);
        Task<bool> Exists(Guid id);
    }
}
