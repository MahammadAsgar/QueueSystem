using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueSystem.Domain.Entities.Users
{
    public class AppUser:IdentityUser<int>
    {
        public string FullName { get; set; }
        public List<QueueTicket>? Tikets { get; set; }
        public List<Service>? Services { get; set; }
    }
}
