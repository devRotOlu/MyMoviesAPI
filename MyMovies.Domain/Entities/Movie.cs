namespace MyMovies.Domain.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Genre { get; set; } = null!;
        public string Director { get; set; } = null!;
        public string ThumbnailUrl { get; set; } = null!;
        public string VideoPath { get; set; } = null!;
        public DateTime ReleaseDate { get; set; }
        public int DurationMinutes { get; set; }
        public DateTime AddedAt { get; } = DateTime.UtcNow;
    }
}
