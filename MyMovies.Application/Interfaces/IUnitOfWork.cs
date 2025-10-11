using MyMovies.Application.Interfaces.IRepository;

namespace MyMovies.Application.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        IMovieRepository Movies { get; }
        void CommitAsync();
        void RollbackAsync();
    }
}
