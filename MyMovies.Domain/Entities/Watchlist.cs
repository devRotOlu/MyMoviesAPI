namespace MyMovies.Domain.Entities
{
    public class Watchlist
    {
        public int UserId { get; set; }
        public int MovieId { get; set; }
        public User User { get; set; } = null!;
        public Movie Movie { get; set; } = null!;
        public DateTime AddedAt { get; } = DateTime.UtcNow;
    }
}
