using QueueSystem.Infrasturucture.DTOs.Customer;

namespace QueueSystem.Infrasturucture.DTOs.Queue
{
    public class GetQueueDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime? UpdateDateTime { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? FinishDateTime { get; set; }
        public DateTime? FreezeDateTime { get; set; }
        public DateTime? AfterFreezeDateTime { get; set; }
        public PriorityDTO Priority { get; set; }
        public WorkerDTO Worker { get; set; }
        public GetCustomerDTO Customer { get; set; }
        public StatusDTO Status { get; set; }
    }
}
