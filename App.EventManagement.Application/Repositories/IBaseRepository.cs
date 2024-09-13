


using App.EventManagement.Domain.Common;
using App.EventManagement.Domain.Entities;
using System.Linq.Expressions;
namespace App.EventManagement.Application.Repositories;
public interface IBaseRepository 
{
    void Create(ServiceRequest entity);
    void Update(ServiceRequest entity);
    void Delete(Guid id);
    Task<ServiceRequest> GetById(Guid id, CancellationToken cancellationToken);
    Task<List<ServiceRequest>> GetAll(int pageNumber , int pageSize, CancellationToken cancellationToken);
}