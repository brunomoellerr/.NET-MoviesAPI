using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Data;
using MoviesAPI.Models;
using MoviesAPI.Data.Dtos;
using AutoMapper;

namespace MoviesAPI.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class MovieController : ControllerBase
  {

    private MovieContext _context;
    private IMapper _mapper;
    public MovieController(MovieContext context, IMapper mapper)
    {
      _context = context;
      _mapper = mapper;
    }


    [HttpPost]
    public IActionResult AddMovie([FromBody] CreateMovieDto movieDto)
    {
      Movie movie = _mapper.Map<Movie>(movieDto);

      _context.Movies.Add(movie);
      _context.SaveChanges();
      return CreatedAtAction(nameof(GetMovieById), new { Id = movie.Id }, movie);
    }

    [HttpGet]
    public IActionResult GetMovies([FromQuery] int? ageRestriction = null)
    {
      List<Movie> movies;
      if (ageRestriction == null)
      {
        movies = _context.Movies.ToList();
      }
      else
      {
      movies = _context.Movies.ToList();
        movies = movies.Where(movie => movie.AgeRestriction >= ageRestriction).ToList();
      }
      

      if (movies != null)
      {
        List<ReadMovieDto> moviesDto = _mapper.Map<List<ReadMovieDto>>(movies);
        return Ok(moviesDto);
      }
      return NotFound();
    }

    [HttpGet("{id}")]
    public IActionResult GetMovieById(int id)
    {
      Movie movie = _context.Movies.FirstOrDefault(movie => movie.Id == id);
      if (movie != null)
      {
        ReadMovieDto movieDto = _mapper.Map<ReadMovieDto>(movie);
        return Ok(movieDto);
      }
      return NotFound();
    }

    [HttpPut("{id}")]
    public IActionResult UpdateMovie(int id, [FromBody] UpdateMovieDto movieDto)
    {
      Movie movie = _context.Movies.FirstOrDefault(movie => movie.Id == id);
      if (movie == null)
      {
        return NotFound();
      }

      _mapper.Map(movieDto, movie);

      _context.SaveChanges();
      return NoContent();

    }

    [HttpDelete("{id}")]
    public IActionResult DeleteMovie(int id)
    {
      Movie movie = _context.Movies.FirstOrDefault(movie => movie.Id == id);
      if (movie == null)
      {
        return NotFound();
      }

      _context.Remove(movie);
      _context.SaveChanges();
      return NoContent();
    }
  }
}