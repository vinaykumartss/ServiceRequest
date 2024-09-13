using App.EventManagement.Application.Repositories;
using App.EventManagement.Domain;
using App.EventManagement.Domain.Entities;
using App.EventManagement.Infrastructure.Context;

namespace App.EventManagement.Infrastructure.Repositories;

public class BaseRepository : IBaseRepository
{
    public static List<ServiceRequest> AllData { get; set; } = new List<ServiceRequest>();
    protected readonly EventManagementDbContext Context;

    public BaseRepository(EventManagementDbContext context)
    {
        Context = context;
    }

    public void Create(ServiceRequest entity)
    {
        
        AllData.Add(entity);
      
    }

    public void Update(ServiceRequest entity)
    {
        AllData.Where(c => c.Id == entity.Id).ToList().Select(c => { c.BuildingCode = entity.BuildingCode;c.CurrentStatus = CurrentStatus.Complete.ToString(); return c; });

    }

    public void Delete(Guid id)
    {
        AllData.RemoveAll((x) => x.Id == id);
    }

    public async Task<ServiceRequest> GetById(Guid id, CancellationToken cancellationToken)
    {
        return await Task.FromResult(AllData.Where(x=>x.Id == id).FirstOrDefault());
    }

    public async Task<List<ServiceRequest>> GetAll(int pageNumber, int pageSize, CancellationToken cancellationToken)
    {
        return await Task.FromResult(AllData);
    }


 
}