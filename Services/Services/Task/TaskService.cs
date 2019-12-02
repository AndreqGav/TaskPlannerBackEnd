using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskPlanner.Data.Models;
using TaskPlanner.Data.Repositories;
using TaskPlanner.Services.DtoModel;

namespace TaskPlanner.Services.Services.Task
{
    public class TaskService : BaseService<TaskModel>, ITaskService
    {
        private readonly ILogger _logger;

        public TaskService(IMapper mapper, DbContext context, IRepository<TaskModel> repository, ILogger logger)
           : base(mapper, context, repository)
        {
            _logger = logger;
        }
        public async Task<Guid> AddAsync(TaskModelDto item)
        {
            var domainItem = _mapper.Map<TaskModel>(item);
            _repository.Insert(domainItem);

            await _context.SaveChangesAsync();

            return domainItem.Id;
        }

        public async ValueTask DeleteAsync(Guid id)
        {
            var domainItem = _repository.GetByIDAsync(id);
            _repository.Delete(domainItem);

            await _context.SaveChangesAsync();
        }

        public async Task<List<TaskModelDto>> FindAll()
        {
            var item = await _repository.GetAsync(null);
            List<TaskModelDto> domainItem = new List<TaskModelDto>();
            foreach (var itm in item)
            {
                domainItem.Add(_mapper.Map<TaskModelDto>(item));
            }

            return domainItem;
        }

        public async Task<TaskModelDto> FindByID(Guid id)
        {
            var item = await _repository.GetByIDAsync(id);
            var domainItem = _mapper.Map<TaskModelDto>(item);

            return domainItem;

        }

        public async ValueTask UpdateAsync(TaskModelDto item)
        {
            var domainItem = _mapper.Map<TaskModel>(item);
            _repository.Update(domainItem);

            await _context.SaveChangesAsync();
        }

        public async Task<bool> Exists(Guid id)
        {
            return await _repository.Exists(b => b.Id == id);
        }

    }
}
