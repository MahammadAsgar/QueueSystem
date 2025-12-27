using Microsoft.AspNetCore.Identity;

namespace QueueSystem.Domain.Entities.Users
{
    public class AppUser : IdentityUser<int>
    {
        public string FullName { get; set; }
        public List<Ticket>? Tikets { get; set; }
        public List<Service>? Services { get; set; }
    }
}
