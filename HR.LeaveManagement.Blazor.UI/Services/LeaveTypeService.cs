using AutoMapper;
using HR.LeaveManagement.Blazor.UI.Contracts;
using HR.LeaveManagement.Blazor.UI.Models.LeaveTypes;
using HR.LeaveManagement.Blazor.UI.Services.Base;

namespace HR.LeaveManagement.Blazor.UI.Services
{
    public class LeaveTypeService : BaseHttpService, ILeaveTypeService
    {
        //private readonly IClient _client;
        private readonly IMapper _mapper;

        public LeaveTypeService(IClient client, IMapper mapper) : base(client)
        {
            //this._client = client;
            this._mapper = mapper;
        }

        public async Task<Response<Guid>> CreateLeaveType(LeaveTypeVM leaveType)
        {
            //N>B CreateLeaveTypeCommand is like our DTO, that's the data we are submmitting when creating so its mapping with LeaveType Vm
            try
            {
                await AddBearerToken();
                var createLeaveTypeCommand = _mapper.Map<CreateLeaveTypeCommand>(leaveType);
                await _client.LeaveTypePOSTAsync(createLeaveTypeCommand);
                return new Response<Guid>()
                {
                    Success = true,
                };
            }
            catch (ApiException ex)
            {

                return ConvertApiExceptions<Guid>(ex);
            }
        }

        public async Task<Response<Guid>> DeleteLeaveType(int id)
        {
            try
            {
                await AddBearerToken();
                await _client.LeaveTypeDELETEAsync(id);
                return new Response<Guid>() { Success = true };
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<Guid>(ex);
            }
        }

        public async Task<LeaveTypeVM> GetLeaveTypeDetails(int id)
        {
            await AddBearerToken();
            var leaveType = await _client.LeaveTypeGETAsync(id);
            return _mapper.Map<LeaveTypeVM>(leaveType);
        }

        public async Task<List<LeaveTypeVM>> GetLeaveTypes()
        {
            await AddBearerToken();
            var leaveTypes = await _client.LeaveTypeAllAsync();
            return _mapper.Map<List<LeaveTypeVM>>(leaveTypes);
        }

        public async Task<Response<Guid>> UpdateLeaveType(int id, LeaveTypeVM leaveType)
        {
            try
            {
                await AddBearerToken();
                var updateLeaveTypeCommand = _mapper.Map<UpdateLeaveTypeCommand>(leaveType);
                await _client.LeaveTypePUTAsync(id.ToString(), updateLeaveTypeCommand);
                return new Response<Guid>()
                {
                    Success = true,
                };
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<Guid>(ex);
            }
        }
    }
}
