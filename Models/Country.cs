namespace ArabCuisine.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public required string ImageUrl { get; set; }
    }
}
