using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskPlanner.Data.Repositories;

namespace TaskPlanner.Services.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        protected readonly IMapper _mapper;
        protected readonly IRepository<TEntity> _repository;
        protected readonly DbContext _context;

        public BaseService(IMapper mapper, DbContext context, IRepository<TEntity> repository)
        {
            _mapper = mapper;
            _context = context;
            _repository = repository;
        }

        // лень реализовывать GuidDomainModel
        public virtual Task<Guid> AddAsync<TDtoEntity>(TDtoEntity item)
        {
            throw new NotImplementedException();
        }

        public virtual Task<IEnumerable<Guid>> AddAsync<TDtoEntity>(IEnumerable<TDtoEntity> items)
        {
            throw new NotImplementedException();
        }

        public virtual ValueTask DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<bool> Exists(Guid id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<TDtoEntity> GetByIdAsync<TDtoEntity>(Guid id)
        {
            throw new NotImplementedException();
        }

        public virtual ValueTask UpdateAsync<TDtoEntity>(TDtoEntity item)
        {
            throw new NotImplementedException();
        }

        public virtual ValueTask UpdateAsync<TDtoEntity>(Guid id, TEntity patchData)
        {
            throw new NotImplementedException();
        }
    }
}
