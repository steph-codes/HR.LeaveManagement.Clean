using AutoMapper;
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
            
            CreateMap<LeaveTypeDto, LeaveType>().ReverseMap();

            CreateMap<LeaveType, LeaveTypeDetailsDto>();
        }

    }
}
