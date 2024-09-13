using App.EventManagement.Application.Repositories;
using App.EventManagement.Domain.Entities;
using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;

namespace App.EventManagement.Application.Features.Query.GetAllRquest;

public sealed class GetAllHandler : IRequestHandler<GetAllRquest, List<ServiceRequest>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IServiceRequestRepository _userRepository;
    private readonly IMapper _mapper;
    private readonly ILogger<GetAllHandler> _logger;
    private readonly IMediator _mediator;


    public GetAllHandler(IUnitOfWork unitOfWork, IServiceRequestRepository userRepository,
        IMapper mapper, ILogger<GetAllHandler> logger, IMediator mediator)
    {
        _unitOfWork = unitOfWork;
        _userRepository = userRepository;
        _mapper = mapper;
        _logger = logger;
        _mediator = mediator;
    }

    public async Task<List<ServiceRequest>> Handle(GetAllRquest request, CancellationToken cancellationToken)
    {
        GetAllResponse response = new GetAllResponse();
        try
        {
            List<ServiceRequest> user = await _userRepository.GetAll(request.PageNumber, request.PageSize, cancellationToken);

        
            return await Task.FromResult(user);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.Message);
            throw;
        }
    }
}