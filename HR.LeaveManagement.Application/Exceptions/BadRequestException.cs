using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Exceptions
{
    public class BadRequestException : Exception
    {
        public BadRequestException(string message ) : base(message)
        {
            
        }

        //public List<string> ValidationErrors { get; set; }
        public IDictionary<string, string[]> ValidationErrors { get; set; }  //key string key name, value is the list of errors for that key
        public BadRequestException( string message, ValidationResult validationResult ) : base(message)
        {
            //ValidationErrors = new();
            //foreach ( var error in validationResult.Errors)
            //{ 
            //    //Add error from the loop into the list of ValidationError
            //    ValidationErrors.Add(error.ErrorMessage);
            //}
            ValidationErrors = validationResult.ToDictionary();
            
        }
    }
}
