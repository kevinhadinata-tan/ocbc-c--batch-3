using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieApp.Models;
using MovieApp.Data;

namespace MovieApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class MovieController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public MovieController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetMovies()
        {
            var movies = await _context.Movies.ToListAsync();
            return Ok(movies);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMovie(MovieData data)
        {
            if (ModelState.IsValid)
            {
                await _context.Movies.AddAsync(data);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetMovie", new {data.Id}, data);
            }

            return new JsonResult("Something went wrong") {StatusCode = 500};
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMovie(int id)
        {
            var movie = await _context.Movies.FirstOrDefaultAsync(x => x.Id == id);

            if (movie == null)
            {
                return NotFound();
            }

            return Ok(movie);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMovie(int id, MovieData movie)
        {
            if (id != movie.Id)
            {
                return BadRequest();
            }

            var existMovie = await _context.Movies.FirstOrDefaultAsync(x => x.Id == id);

            if (existMovie == null)
            {
                return NotFound();
            }

            existMovie.Name = movie.Name;
            existMovie.Genre = movie.Genre;
            existMovie.Duration = movie.Duration;
            existMovie.releaseDate = movie.releaseDate;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovie(int id)
        {
            var existMovie = await _context.Movies.FirstOrDefaultAsync(x => x.Id == id);

            if (existMovie == null)
            {
                return NotFound();
            }

            _context.Movies.Remove(existMovie);
            await _context.SaveChangesAsync();

            return Ok(existMovie);
        }
    }
}