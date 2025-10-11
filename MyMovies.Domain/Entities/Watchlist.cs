namespace MyMovies.Domain.Entities
{
    public class Watchlist
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MovieId { get; set; }
        public User User { get; set; } = null!;
        public Movie Movie { get; set; } = null!;
    }
}
