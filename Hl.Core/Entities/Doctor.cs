using Hl.Core.Common;

namespace Hl.Core.Entities
{
    public class Doctor: BaseEntities
    {
        public int AppUSerId { get; set; }
        public AppUser AppUser { get; set; } = null!;
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; } = null!;
        public string Title  { get; set; } = string.Empty;


    }
}
