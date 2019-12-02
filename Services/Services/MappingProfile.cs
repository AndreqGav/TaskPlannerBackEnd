using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskPlanner.Data.Models;
using TaskPlanner.Services.DtoModel;

namespace TaskPlanner.Services.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TaskModel, TaskModelDto>();
            CreateMap<TaskModelDto, TaskModel>();
        }
    }
}
