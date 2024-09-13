
using App.EventManagement.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;
namespace App.EventManagement.Domain.Entities
{
    [Table("serviceRequest")]
    public class ServiceRequest : BaseEntity
    {
        [Column("buildingCode")]
        public string? BuildingCode { get; set; }

        [Column("description")]
        public string? Description { get; set; }

        [Column("currentStatus")]
        public string CurrentStatus { get; set; }
    }
}
