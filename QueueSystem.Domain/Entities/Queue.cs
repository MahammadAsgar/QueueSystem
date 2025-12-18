using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueSystem.Domain.Entities
{
    public class Queue : BaseEntity
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
        public Priority Priority { get; set; }
        public Worker Worker { get; set; }
        public Customer Customer { get; set; }
        public Status Status { get; set; }
    }
}
