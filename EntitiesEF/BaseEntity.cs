using System.ComponentModel.DataAnnotations;

namespace EntitiesEF
{
    public interface IBaseEntity
    {
        Guid Id {get; set;}
        DateTime CreatedAt {get; set;}
        DateTime? LastModifiedAt {get; set;}
        string CreatedBy {get; set;}
        string LastModifiedBy {get; set;}
        int Version { get; set; }
        bool Deleted { get; set; }
        bool Enabled { get; set; }
    }

    public class BaseEntity : IBaseEntity
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? LastModifiedAt { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }

        [ConcurrencyCheck]
        public int Version { get; set; } = 0;
        public bool Deleted { get; set; } = false;
        public bool Enabled { get; set; } = true;
    }
}