using App.EventManagement.Application.Common.Exceptions;
using App.EventManagement.Application.Repositories;
using App.EventManagement.Domain.Entities;
using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
namespace App.EventManagement.Application.Features.Comand.UpdateRequest;

public sealed class UpdateRequestHandler : IRequestHandler<UpdateRequest, UpdateResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IServiceRequestRepository _serviceRequestRepository;
    private readonly IMapper _mapper;
    private readonly ILogger<UpdateRequestHandler> _logger;
    private readonly IMediator _mediator;
    public UpdateRequestHandler(IUnitOfWork unitOfWork, IServiceRequestRepository serviceRequestRepository,
        IMapper mapper, ILogger<UpdateRequestHandler> logger, IMediator mediator)
    {
        _unitOfWork = unitOfWork;
        _serviceRequestRepository = serviceRequestRepository;
        _mapper = mapper;
        _logger = logger;
        _mediator = mediator;
    }

    public async Task<UpdateResponse> Handle(UpdateRequest request, CancellationToken cancellationToken)
    {
        UpdateResponse response = new UpdateResponse();
        try
        {
            ServiceRequest requestService = new ServiceRequest();
            requestService.BuildingCode = request.BuildingCode;
            requestService.Id = request.id;
            _serviceRequestRepository.Update(requestService);
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