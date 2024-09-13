using App.EventManagement.Application.Common.Exceptions;
using App.EventManagement.Application.Repositories;
using App.EventManagement.Domain;
using App.EventManagement.Domain.Entities;
using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;

namespace App.EventManagement.Application.Features.Comand.CreateRequest;

public sealed class CreateRequestHandler : IRequestHandler<CreateRequest, CreateResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IServiceRequestRepository _serviceRequestRepository;
    private readonly IMapper _mapper;
    private readonly ILogger<CreateRequestHandler> _logger;
    private readonly IMediator _mediator;
    public CreateRequestHandler(IUnitOfWork unitOfWork, IServiceRequestRepository serviceRequestRepository,
        IMapper mapper, ILogger<CreateRequestHandler> logger, IMediator mediator)
    {
        _unitOfWork = unitOfWork;
        _serviceRequestRepository = serviceRequestRepository;
        _mapper = mapper;
        _logger = logger;
        _mediator = mediator;
    }

    public async Task<CreateResponse> Handle(CreateRequest request, CancellationToken cancellationToken)
    {
        CreateResponse response = new CreateResponse();
        try
        {

            var data = _mapper.Map<ServiceRequest>(request);
            data.CurrentStatus = CurrentStatus.Created.ToString();
            _serviceRequestRepository.Create(data);
            response.IsSuccess = true;
        }
        catch (BadRequestException ex)
        {
            throw;
        }
        catch (Exception ex)
        {
            throw new Exception("Something went wrong, please try again");

        }
        return response;
    }
}