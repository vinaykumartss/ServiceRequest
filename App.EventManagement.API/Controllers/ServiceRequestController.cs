using App.EventManagement.Application.Features.Comand.CreateRequest;
using App.EventManagement.Application.Features.Comand.DeleteRequest;
using App.EventManagement.Application.Features.Comand.UpdateRequest;
using App.EventManagement.Application.Features.Query.GetAllRquest;
using App.EventManagement.Application.Features.Query.GetById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace App.EventManagement.API.Controllers
{
    [ApiController]
    [Route("service-request")]
    public class ServiceRequestController : ControllerBase
    {
        private readonly IMediator _mediator;
       
        public ServiceRequestController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<GetAllResponse>> GetAll(CancellationToken cancellationToken)
        {
            GetAllRquest allRquest= new GetAllRquest();
            var response = await _mediator.Send(allRquest, cancellationToken);
            return Ok(response);
        }

        [HttpGet("GetById/{id}")]
        public async Task<ActionResult<GetByIdResponse>> GetById(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                GetByIdRquest request = new GetByIdRquest();
                request.Id = id;
                   var response = await _mediator.Send(request, cancellationToken);
                return Ok(response);
            }
            catch (Exception ex)
            {
       
                throw;
            }
        }


        [HttpPost("create")]
        public async Task<ActionResult<CreateResponse>> Create(CreateRequest request,
            CancellationToken cancellationToken)
        {
            try
            {
                var response = await _mediator.Send(request, cancellationToken);
                return Ok(response);
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }


        [HttpPost("Update/{id}")]
        public async Task<ActionResult<UpdateResponse>> Update(Guid id, UpdateRequest request,
            CancellationToken cancellationToken)
        {
            try
            { 
                var response = await _mediator.Send(request, cancellationToken);
                return Ok(response);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPost("Delete/{id}")]
        public async Task<ActionResult<DeleteResponse>> Delete(Guid id,
           CancellationToken cancellationToken)
        {
            try
            {
                DeleteRequest request = new DeleteRequest();
                request.Id = id;
                var response = await _mediator.Send(request, cancellationToken);
                return Ok(response);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}