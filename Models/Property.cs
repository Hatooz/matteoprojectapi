namespace MatteoRbProject.Models
{
    public class Property
    {
        public Guid Id { get; set; }
       
        public string ObjectNumber { get; set; }
        public int LMNumber { get; set; }
        public Guid QueueRuleId { get; set; }
        public QueueRule QueueRule { get; set; }
        public List<Appartment> Appartments { get; set; } = new List<Appartment>();
        public List<Address> Addresses { get; set; } = new List<Address>();
    }

    public class PropertyDTO 
    {
        public Guid Id { get; set; }
        public string ObjectNumber {get; set;}
        public int LMNumber {get; set;}
        public QueueRuleDTO QueueRule { get; set; }

        public List<AddressDTO> Addresses { get; set; }

        public List<AppartmentListDTO> Appartments { get; set; }
    }
    public record CreatePropertyDTO(string ObjectNumber, int LMNumber, Guid QueueRuleId);

    public record UpdatePropertyDTO(Guid QueueRuleId);
}
