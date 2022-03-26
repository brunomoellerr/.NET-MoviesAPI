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
  public class ManagerController : ControllerBase
  {
    private MovieContext _context;
    private IMapper _mapper;

    public ManagerController(MovieContext context, IMapper mapper)
    {
      _context = context;
      _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AddManager(CreateManagerDto managerDto)
    {
      Manager manager = _mapper.Map<Manager>(managerDto);
      _context.Managers.Add(manager);
      _context.SaveChanges();
      return CreatedAtAction(nameof(GetManagersById), new { Id = manager.Id }, manager);
    }

    [HttpGet("{id}")]
    public IActionResult GetManagersById(int id)
    {
      Manager manager = _context.Managers.FirstOrDefault(manager => manager.Id == id);
      if (manager != null)
      {
        ReadManagerDto managerDto = _mapper.Map<ReadManagerDto>(manager);

        return Ok(managerDto);
      }
      return NotFound();
    }
  }
}