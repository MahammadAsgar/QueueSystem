namespace QueueSystem.Domain.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
