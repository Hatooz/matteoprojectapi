namespace MatteoRbProject.Models
{
    public class Application
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid AppartmentId { get; set; }
        public Appartment Appartment { get; set; }
    }

    public record CreateApplicationDTO(Guid UserId, Guid AppartmentId);
}
