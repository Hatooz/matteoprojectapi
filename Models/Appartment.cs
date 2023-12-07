namespace MatteoRbProject.Models
{
    public class Appartment
    {
        public Guid Id { get; set; }
        public Guid AddressId { get; set; }
        public Address Address { get; set; }
        public string ObjectNumber { get; set; }
        public int LMNumber { get; set; }
        public Guid QueueRuleId { get; set; }
        public QueueRule QueueRule { get; set; }
        public Guid PropertyId { get; set; }
        public Property Property { get; set; }
        public Guid? AdvertId { get; set; }
        public Advert? Advert { get; set; }
        public List<Application>? Applications { get; set; }

    }

    public class AppartmentListDTO
    {
        public Guid Id { get; set; }
        public Guid AddressId { get; set; }
        public Guid QueueRuleId { get; set; }
        public Guid PropertyId { get; set; }
        public Guid? AdvertId { get; set; }
    }

    public class AppartmentDTO 
    {
        public Guid Id { get; set; }
        public AddressDTO Address { get; set; }
        public string ObjectNumber { get; set; }
        public int LMNumber { get; set; }        
        public QueueRuleDTO QueueRule { get; set; }
        public Guid PropertyId { get; set; }
        public AdvertDTO? Advert { get; set; }
        public int? TotalApplications { get; set; }
    }

    public record UpdateAppartmentDTO(Guid QueueRuleId);
}
