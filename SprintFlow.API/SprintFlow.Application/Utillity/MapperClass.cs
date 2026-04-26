using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SprintFlow.Application.Dto;
using SprintFlow.Domain.Entity;

namespace SprintFlow.Application.Utillity
{
    public class MapperClass : Profile
    {
        public MapperClass()
        {
            CreateMap<Login, LoginDto>();

        }
    }
}
