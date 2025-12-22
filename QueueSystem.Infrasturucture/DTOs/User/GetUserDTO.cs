using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueSystem.Infrasturucture.DTOs.User
{
    public class GetUserDTO
    {
        public string FullName { get; set; }
        public List<ServiceDTO>? Services { get; set; }
    }
}
