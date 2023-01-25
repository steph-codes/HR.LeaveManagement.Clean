using HR.LeaveManagement.Application.Contracts.Logging;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Leavemanagement.Infrastructure.Logging
{
    public class LoggerAdapter<T> : IAppLogger<T>
    {

        //ILoggerFactory help creates logs based on the class we are working on, thats why we have class <T>
        //creates the logs min the constructor, ILogger<T> is a built in ppties from microsft.Extension.Logging
        
        private readonly ILogger<T> _logger;
        public LoggerAdapter(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<T>();
        }
        public void LogInformation(string message, params object[] args)
        {
            _logger.LogInformation(message, args);
        }

        public void LogWarning(string message, params object[] args)
        {
            _logger.LogWarning(message, args);
        }
    }
}
