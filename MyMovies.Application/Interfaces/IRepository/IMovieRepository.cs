using MyMovies.Domain.Entities;

namespace MyMovies.Application.Interfaces.IRepository
{
    public interface IMovieRepository : IGenericRepository<Movie>
    {
        Task<IEnumerable<Movie>> SearchMoviesAsync(string keyword);
    }
}
