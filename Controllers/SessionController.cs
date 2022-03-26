using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Data;
using MoviesAPI.Data.Dtos;
using MoviesAPI.Models;

namespace MoviesAPI.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class SessionController : ControllerBase
  {
    private MovieContext _context;
    private IMapper _mapper;

    public SessionController(MovieContext context, IMapper mapper)
    {
      _context = context;
      _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AddSession(CreateSessionDto sessionDto){
      Session session = _mapper.Map<Session>(sessionDto);
      _context.Sessions.Add(session);
      _context.SaveChanges();
      return CreatedAtAction(nameof(GetSessionById), new { id = session.Id }, session);
    }

    [HttpGet("{id}")]
    public IActionResult GetSessionById(int id){
      Session session = _context.Sessions.FirstOrDefault(session => session.Id == id);
      if(session == null){
        return NotFound();
      }
      ReadSessionDto sessionDto = _mapper.Map<ReadSessionDto>(session);
      return Ok(sessionDto);
    }
  }
}