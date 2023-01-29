using HR.LeaveManagement.Blazor.UI.Contracts;
using HR.LeaveManagement.Blazor.UI.Services.Base;

namespace HR.LeaveManagement.Blazor.UI.Services
{
    public class LeaveAllocationService : BaseHttpService, ILeaveAllocationService
    {
        public LeaveAllocationService(IClient client) : base(client)
        {

        }
    }
}
