using HR.LeaveManagement.Blazor.UI.Models.LeaveAllocations;

namespace HR.LeaveManagement.Blazor.UI.Models.LeaveRequests
{
    public class EmployeeLeaveRequestViewVM
    {
        public List<LeaveAllocationVM> LeaveAllocations { get; set; }
        public List<LeaveRequestVM> LeaveRequests { get; set; }
    }
}
