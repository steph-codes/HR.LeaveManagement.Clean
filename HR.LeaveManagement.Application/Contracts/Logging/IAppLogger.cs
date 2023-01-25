using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Contracts.Logging
{
    public interface IAppLogger<T>
    {
        //creates logs based on the class we are working on, thats why we have class <T>

        // Add as much as Possible Methods, they are many Asp.NET logging methods

        void LogInformation(string message, params object[] args);
        void LogWarning(string message, params object[] args);
    }
}
