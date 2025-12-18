using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueSystem.Infrasturucture.DTOs.Customer
{
    public class GetCustomerDTO
    {
        public string FullName { get; set; }
        public ServiceDTO Service { get; set; }
    }
}
