using System.Runtime.Serialization;

namespace HR.LeaveManagement.Application.Exceptions
{
    [Serializable]
    public class NotFoundException : Exception
    {
        public NotFoundException(string name, object key) : base($"{name} ({key}) was not found")
        {
            
        }
    }
}