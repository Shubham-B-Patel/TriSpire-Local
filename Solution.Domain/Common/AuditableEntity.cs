namespace Solution.Domain.Common
{
    public class AuditableEntity
    {
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? CreatedIpAddress { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public string? LastModifiedIpAddress { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
        public int? DeletedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
        public string? DeletedIpAddress { get; set; }
    }
}
