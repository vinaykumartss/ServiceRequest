using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.EventManagement.Domain.Common
{
    public abstract class BaseEntity
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Column("createdBy")]
        public string? CreatedBy { get; set; }

        [Column("createdDate")]
        public DateTime CreatedDate { get; set; }

        [Column("lastModifiedBy")]
        public string? LastModifiedBy { get; set; }

        [Column("lastModifiedDate")]
        public DateTime LastModifiedDate { get; set; }

    }
}
