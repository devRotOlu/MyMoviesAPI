using Microsoft.AspNetCore.Mvc;
using MyMovies.Application.Interfaces;
using MyMovies.Domain.Entities;

namespace MyMovies.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public MoviesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost("add-movie")]
        public async Task<IActionResult> AddMovie(Movie movie)
        {
            try
            {
                await _unitOfWork.Movies.AddAsync(movie);
                _unitOfWork.CommitAsync();
                return Ok("Movie added successfully");
            }
            catch
            {
                _unitOfWork.RollbackAsync();
                return BadRequest("Failed to add movie");
            }
        }
    }
}
