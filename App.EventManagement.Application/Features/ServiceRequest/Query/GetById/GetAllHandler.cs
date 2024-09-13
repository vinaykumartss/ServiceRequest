using App.EventManagement.Application.Repositories;
using App.EventManagement.Domain.Entities;
using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;

namespace App.EventManagement.Application.Features.Query.GetById;

public sealed class GetByIdHandler : IRequestHandler<GetByIdRquest, ServiceRequest>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IServiceRequestRepository _serviceRequestRepository;
    private readonly IMapper _mapper;
    private readonly ILogger<GetByIdHandler> _logger;
    private readonly IMediator _mediator;
    public GetByIdHandler(IUnitOfWork unitOfWork, IServiceRequestRepository serviceRequestRepository,
        IMapper mapper, ILogger<GetByIdHandler> logger, IMediator mediator)
    {
        _unitOfWork = unitOfWork;
        _serviceRequestRepository = serviceRequestRepository;
        _mapper = mapper;
        _logger = logger;
        _mediator = mediator;
    }

    public async Task<ServiceRequest> Handle(GetByIdRquest request, CancellationToken cancellationToken)
    {
        GetByIdResponse response = new GetByIdResponse();
        try
        {
            ServiceRequest user = await _serviceRequestRepository.GetById(request.Id, cancellationToken);
            return await Task.FromResult(user);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.Message);
            throw;
        }
    }
}