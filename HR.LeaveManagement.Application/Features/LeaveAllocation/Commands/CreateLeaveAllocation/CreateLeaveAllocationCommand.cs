using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveAllocation.Commands.CreateLeaveAllocation
{
    public class CreateLeaveAllocationCommand : IRequest<Unit>
    {
        //that's why this is important, the kind of leave you want to go for 
        public int LeaveTypeId { get; set; }
    }
}
