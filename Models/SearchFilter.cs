namespace MatteoRbProject.Models
{
    public class SearchFilter
    {
        public bool includeRules { get; set; } = false;
        public bool includeAddress { get; set; } = false;
        public bool includeObjectNumber { get; set; } = false;
        public bool includeLmNumber { get; set; } = false;
        public bool includeHasAdvert { get; set; } = false;

        public string? SearchString { get; set; } = string.Empty;
    }
}
