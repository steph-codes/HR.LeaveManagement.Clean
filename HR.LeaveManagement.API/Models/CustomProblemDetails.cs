using Microsoft.AspNetCore.Mvc;

namespace HR.LeaveManagement.API.Models
{
    //problem details built in MVc Model class with type json
    public class CustomProblemDetails : ProblemDetails
    {
        public IDictionary<string, string[]> Errors { get; set; } = new Dictionary<string, string[]>();
    }
}
