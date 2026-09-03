

namespace Hl.Core.Common
{
    public abstract class BaseEntities
    {
        public int Id { get; set; }
        public DateTime Created { get; set; } = DateTime.UtcNow;

        public required string CreatedBy { get; set; }

        public DateTime? Updated { get; set; }

        public string? UpdatedBy { get; set; }

        public bool IsActive { get; set; } = true;

        public bool IsDeleted { get; set; } = false;
    }
}
