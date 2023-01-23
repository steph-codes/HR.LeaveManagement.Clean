using AutoMapper;
using HR.LeaveManagement.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveType.Commands.CreateLeaveType
{
    public class CreateLeaveTypeCommandHandler : IRequestHandler<CreateLeaveTypeCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public CreateLeaveTypeCommandHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
        {
            _mapper = mapper;
            _leaveTypeRepository = leaveTypeRepository;
        }

        public async Task<int> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            // Validate incoming data
            //var validator = new CreateLeaveTypeCommandValidator(_leaveTypeRepository);
            //var validationResult = await validator.ValidateAsync(request);

            //if (validationResult.Errors.Any())
            //    throw new BadRequestException("Invalid Leave type", validationResult);

            // convert to domain entity object

            //its seeing LeaveType as a namesapce aswell as datatype so u refrence which leavetype and thats why we used domain from domainProject
            var leaveTypeToCreate = _mapper.Map<Domain.LeaveType>(request);

            // add to database
            await _leaveTypeRepository.CreateAsync(leaveTypeToCreate);

            // return record id of the newly created record
            return leaveTypeToCreate.Id;
        }
    }
}
