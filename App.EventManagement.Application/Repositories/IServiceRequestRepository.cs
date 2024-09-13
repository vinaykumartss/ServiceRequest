
using App.EventManagement.Domain.Entities;

namespace App.EventManagement.Application.Repositories;

public interface IServiceRequestRepository : IBaseRepository
{
    Task<ServiceRequest> GetByEmail(string email, CancellationToken cancellationToken);
}