using HR.LeaveManagement.Blazor.UI.Models.LeaveTypes;
using HR.LeaveManagement.Blazor.UI.Services.Base;

namespace HR.LeaveManagement.Blazor.UI.Contracts
{
    public interface ILeaveTypeService
    {
        Task<List<LeaveTypeVM>> GetLeaveTypes();
        Task<LeaveTypeVM> GetLeaveTypeDetails(int id);
        Task<Response<Guid>> CreateLeaveType(LeaveTypeVM leaveType);
        Task<Response<Guid>> UpdateLeaveType(int id, LeaveTypeVM leaveType);
        Task<Response<Guid>> DeleteLeaveType(int id);
    }
}
