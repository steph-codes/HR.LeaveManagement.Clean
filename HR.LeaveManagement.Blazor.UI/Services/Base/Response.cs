namespace HR.LeaveManagement.BlazorUI.Services.Base
{
    public class Response<T>
    {
        //<T> is guid in this case
        public string Message { get; set; }
        public string ValidationErrors { get; set; }
        public bool Success { get; set; } = true;
        public T Data { get; set; }
    }
}
