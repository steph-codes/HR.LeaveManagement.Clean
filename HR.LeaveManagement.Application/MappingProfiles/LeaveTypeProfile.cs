using AutoMapper;
using HR.LeaveManagement.Application.Features.LeaveType.Commands.CreateLeaveType;
using HR.LeaveManagement.Application.Features.LeaveType.Commands.UpdateLeaveType;
using HR.LeaveManagement.Application.Features.LeaveType.Queries.GetAllLeaveTypes;
using HR.LeaveManagement.Application.Features.LeaveType.Queries.GetLeaveTypeDetails;
using HR.LeaveManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.MappingProfiles
{
    public class LeaveTypeProfile : Profile
    {
        public LeaveTypeProfile()
        {
          
            //always map from domain entity to Dto, if you do otherwise then use the reverseMap
            //Only Use reverseMap if you need to map the Domain Object (LeaveType) back to the Dtos
            CreateMap<LeaveTypeDto, LeaveType>().ReverseMap();

            CreateMap<LeaveType, LeaveTypeDetailsDto>();

            CreateMap<CreateLeaveTypeCommand, LeaveType>();

            CreateMap<UpdateLeaveTypeCommand, LeaveType>();
        }

    }
}
