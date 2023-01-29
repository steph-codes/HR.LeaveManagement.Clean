using AutoMapper;
using HR.LeaveManagement.Blazor.UI.Models.LeaveAllocations;
using HR.LeaveManagement.Blazor.UI.Models.LeaveRequests;
using HR.LeaveManagement.Blazor.UI.Models.LeaveTypes;
using HR.LeaveManagement.Blazor.UI.Services.Base;

namespace HR.LeaveManagement.Blazor.UI.MappingProfiles
{
    public class mappingConfig : Profile
    {
        public mappingConfig()
        {
            CreateMap<LeaveTypeDto, LeaveTypeVM>().ReverseMap();
            CreateMap<LeaveTypeDetailsDto, LeaveTypeVM>().ReverseMap();
            CreateMap<CreateLeaveTypeCommand, LeaveTypeVM>().ReverseMap();
            CreateMap<UpdateLeaveTypeCommand, LeaveTypeVM>().ReverseMap();

            CreateMap<LeaveRequestListDto, LeaveRequestVM>().ReverseMap();
            CreateMap<LeaveRequestDetailsDto, LeaveRequestVM>().ReverseMap();
            CreateMap<CreateLeaveRequestCommand, LeaveRequestVM>().ReverseMap();
            CreateMap<UpdateLeaveRequestCommand, LeaveRequestVM>().ReverseMap();

            CreateMap<LeaveAllocationDto, LeaveAllocationVM>().ReverseMap();
            object p = CreateMap<LeaveAllocationDetailsDto, LeaveAllocationVM>().ReverseMap();
            CreateMap<CreateLeaveAllocationCommand, LeaveAllocationVM>().ReverseMap();
            CreateMap<UpdateLeaveAllocationCommand, LeaveAllocationVM>().ReverseMap();
        }
    }
}
