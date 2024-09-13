
using App.EventManagement.Application.Repositories;
using App.EventManagement.Domain.Entities;
using App.EventManagement.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace App.EventManagement.Infrastructure.Repositories;

public class ServiceRequestRepository : BaseRepository, IServiceRequestRepository
{
    public ServiceRequestRepository(EventManagementDbContext context) : base(context)
    {
    }
    
    public Task<ServiceRequest> GetByEmail(string email, CancellationToken cancellationToken)
    {
        return Context.ServiceRequest.FirstOrDefaultAsync(x => x.BuildingCode == email, cancellationToken);
    }
}