using App.EventManagement.Application.Common.Exceptions;
using App.EventManagement.Application.Repositories;
using App.EventManagement.Domain.Entities;
using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;

namespace App.EventManagement.Application.Features.Comand.DeleteRequest;

public sealed class DeleteRequestHandler : IRequestHandler<DeleteRequest, DeleteResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IServiceRequestRepository _serviceRequestRepository;
    private readonly IMapper _mapper;
    private readonly ILogger<DeleteRequestHandler> _logger;
    private readonly IMediator _mediator;
    public DeleteRequestHandler(IUnitOfWork unitOfWork, IServiceRequestRepository serviceRequestRepository,
        IMapper mapper, ILogger<DeleteRequestHandler> logger, IMediator mediator)
    {
        _unitOfWork = unitOfWork;
        _serviceRequestRepository = serviceRequestRepository;
        _mapper = mapper;
        _logger = logger;
        _mediator = mediator;
    }

    public async Task<DeleteResponse> Handle(DeleteRequest request, CancellationToken cancellationToken)
    {
        DeleteResponse response = new DeleteResponse();
        try
        {
              _serviceRequestRepository.Delete(request.Id);
           
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