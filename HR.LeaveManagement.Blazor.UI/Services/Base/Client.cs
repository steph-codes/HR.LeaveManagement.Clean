namespace HR.LeaveManagement.BlazorUI.Services.Base
{
    public partial class Client : IClient
    {
        public HttpClient HttpClient
        {
            get
            {
                //injected right from serviceclient
                return _httpClient;
            }
        }
    }
}
