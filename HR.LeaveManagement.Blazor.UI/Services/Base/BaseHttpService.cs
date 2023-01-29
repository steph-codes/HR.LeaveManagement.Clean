namespace HR.LeaveManagement.BlazorUI.Services.Base
{
    public class BaseHttpService
    {
        private readonly IClient _client;

        public BaseHttpService(IClient client)
        {
            this._client = client;
        }
    }
}
