namespace MatteoRbProject.Models
{
    public class Address
    {
        public Guid Id { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string? NumberAffix { get; set; }
        public string City { get; set; }        
        public string PostalCode { get; set; }
        public string County { get; set; }
        public Guid PropertyId { get; set; }
        public Property Property { get; set; }
        public List<Appartment> Appartments { get; set; }
    }


    public class AddressDTO
    {
        public Guid Id { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string? NumberAffix { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string County { get; set; }
    }
}
