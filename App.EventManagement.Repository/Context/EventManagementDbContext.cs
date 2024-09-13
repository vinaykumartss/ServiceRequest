using App.EventManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.EventManagement.Infrastructure.Context;

public class EventManagementDbContext : DbContext
{
    public EventManagementDbContext(DbContextOptions<EventManagementDbContext> options) : base(options)
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
    }

  
    public DbSet<ServiceRequest> ServiceRequest { get; set; }
    
}