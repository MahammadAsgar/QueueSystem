using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueSystem.Domain.Entities
{
    public class Customer:BaseEntity
    {
        public string FullName { get; set; }
        public Service Service { get; set; }
    }
}
