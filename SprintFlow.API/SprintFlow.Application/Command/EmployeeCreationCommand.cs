using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SprintFlow.Application.Dto;
using SprintFlow.Application.Utillity;

namespace SprintFlow.Application.Command
{
    public class EmployeeCreationCommand : IRequest<ApiHelper<bool>>
    {
        public EmployeeCreationCommand(UserForCreationDto model)
        {
            Model = model;
        }

        public UserForCreationDto Model { get; set; }
    }
}
