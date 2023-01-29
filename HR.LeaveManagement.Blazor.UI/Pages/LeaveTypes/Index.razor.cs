using HR.LeaveManagement.Blazor.UI.Contracts;
using HR.LeaveManagement.Blazor.UI.Models.LeaveTypes;
using Microsoft.AspNetCore.Components;

namespace HR.LeaveManagement.Blazor.UI.Pages.LeaveTypes
{
    public partial class Index
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Inject]
        public ILeaveTypeService LeaveTypeService { get; set; }

        public List<LeaveTypeVM> LeaveTypes { get; private set; }
        public string Message { get; set; } = string.Empty;

        protected void CreateLeaveType()
        {
            NavigationManager.NavigateTo("/leavetypes/create/");
        }

        protected void AllocateLeaveType(int id)
        {
            // Use Leave Allocation Service here
        }

        protected void EditLeaveType(int id)
        {
            NavigationManager.NavigateTo($"/leavetypes/edit/{id}");
        }

        protected void DetailsLeaveType(int id)
        {
            NavigationManager.NavigateTo($"/leavetypes/details/{id}");
        }

        protected async Task DeleteLeaveType(int id)
        {
            var response = await LeaveTypeService.DeleteLeaveType(id);
            if (response.Success)
            {
                StateHasChanged();
            }
            else
            {
                Message = response.Message;
            }
        }

        protected override async Task OnInitializedAsync()
        {
            //update the empty Leavetype and then render the leavetype in the db
            LeaveTypes = await LeaveTypeService.GetLeaveTypes();
        }
       
    }
}