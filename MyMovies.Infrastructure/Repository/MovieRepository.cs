using Dapper;
using MyMovies.Application.Interfaces.IRepository;
using MyMovies.Domain.Entities;
using System.Data;

namespace MyMovies.Infrastructure.Repository
{
    public class MovieRepository : GenericRepository<Movie>, IMovieRepository
    {
        public MovieRepository(IDbConnection dbConnection,IDbTransaction transaction) : base(dbConnection,transaction) 
        { 
        }
        public async Task<IEnumerable<Movie>> SearchMoviesAsync(string keyword)
        {
            var sql = @"SELECT * FROM movies 
                        WHERE title ILIKE @Keyword OR genre ILIKE @Keyword;";
            return await _dbConnection.QueryAsync<Movie>(sql, new { Keyword = $"%{keyword}%" });
        }
    }
}
