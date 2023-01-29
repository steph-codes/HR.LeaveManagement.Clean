using HR.LeaveManagement.Blazor.UI.Contracts;
using HR.LeaveManagement.Blazor.UI.Services.Base;

namespace HR.LeaveManagement.Blazor.UI.Services
{
    public class LeaveRequestService : BaseHttpService, ILeaveRequestService
    {
        public LeaveRequestService(IClient client) : base(client)
        {

        }
    }
}
