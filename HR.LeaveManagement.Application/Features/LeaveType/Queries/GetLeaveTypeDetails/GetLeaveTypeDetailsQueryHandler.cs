using AutoMapper;
using HR.LeaveManagement.Application.Contracts.Logging;
using HR.LeaveManagement.Application.Contracts.Persistence;
using HR.LeaveManagement.Application.Exceptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetLeaveTypeDetails
{
    public class GetLeaveTypeDetailsQueryHandler : IRequestHandler<GetLeaveTypeDetailsQuery, LeaveTypeDetailsDto>
    {

        private readonly IMapper _mapper;
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IAppLogger<GetLeaveTypeDetailsQueryHandler> _logger;

        public GetLeaveTypeDetailsQueryHandler(IMapper mapper,
            ILeaveTypeRepository leaveTypeRepository,
            IAppLogger<GetLeaveTypeDetailsQueryHandler> logger)
        {
            _mapper = mapper;
            _leaveTypeRepository = leaveTypeRepository;
            this._logger = logger;
        }

        public async Task<LeaveTypeDetailsDto> Handle(GetLeaveTypeDetailsQuery request, CancellationToken cancellationToken)
        {
            // Query the database
            var leaveType = await _leaveTypeRepository.GetByIdAsync(request.Id);

            // verify that record exists
            if (leaveType == null)
                throw new NotFoundException(nameof(LeaveType), request.Id);

            // convert data object to DTO object
            var data = _mapper.Map<LeaveTypeDetailsDto>(leaveType);

            //log informations that leavetypes were retrieved successfully
            _logger.LogInformation("LeaveManagement Types were retrieved successfully");

            // return DTO object
            return data;
        }
    }
}
