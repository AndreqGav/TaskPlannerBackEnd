using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskPlanner.Data.Models;

namespace TaskPlanner.Data.Repositories
{
    public class TaskRepository : Repository<TaskModel>
    {
        public TaskRepository(DbContext context) : base(context)
        {

        }

        public override Task<TaskModel> GetByIDAsync(object id)
        {
            return dbSet.FirstOrDefaultAsync(itm => Equals(itm.Id, id));
        }
    }
}
