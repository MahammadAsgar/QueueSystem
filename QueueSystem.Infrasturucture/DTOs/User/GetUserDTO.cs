namespace QueueSystem.Infrasturucture.DTOs.User
{
    public class GetUserDTO
    {
        public string FullName { get; set; }
        public List<ServiceDTO>? Services { get; set; }
    }
}
