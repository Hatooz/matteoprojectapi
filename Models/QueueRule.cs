namespace MatteoRbProject.Models
{
    public class QueueRule
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public List<Appartment> Appartments { get; set; } = new List<Appartment>();
        public List<Property> Properties { get; set; } = new List<Property>();
    }

    public class QueueRuleDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
