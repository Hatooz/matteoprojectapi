namespace MatteoRbProject.Models
{
    public class Advert
    {
        public Guid Id { get; set; }
        public DateTime? PublishedAt { get; set; }
        public DateTime? RentalDate { get; set; }
        public string AdvertText { get; set; }
        public Guid AppartmentId { get; set; }
        public Appartment Appartment { get; set; }
    }
    
    public class AdvertDTO
    {
        public Guid Id { get; set; }
        public DateTime? PublishedAt { get; set; }
        public DateTime? RentalDate { get; set; }
        public string AdvertText { get; set; }         
    }

    public record CreateAdvertDTO(DateTime? RentalDate, string AdvertText, Guid AppartmentId);
    public record UpdateAdvertDTO(DateTime? RentalDate, string AdvertText);
    
}
