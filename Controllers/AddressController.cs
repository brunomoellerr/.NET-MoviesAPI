using AutoMapper;
using MoviesAPI.Data;
using MoviesAPI.Data.Dtos;
using MoviesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class AddressController : ControllerBase
  {
    private MovieContext _context;
    private IMapper _mapper;

    public AddressController(MovieContext context, IMapper mapper)
    {
      _context = context;
      _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AddAddress([FromBody] CreateAddressDto addressDto)
    {
      Address address = _mapper.Map<Address>(addressDto);
      _context.Addresses.Add(address);
      _context.SaveChanges();
      return CreatedAtAction(nameof(GetAddressesById), new { Id = address.Id }, address);
    }

    [HttpGet]
    public IEnumerable<Address> GetAddresses()
    {
      return _context.Addresses;
    }

    [HttpGet("{id}")]
    public IActionResult GetAddressesById(int id)
    {
      Address address = _context.Addresses.FirstOrDefault(address => address.Id == id);
      if (address != null)
      {
        ReadAddressDto addressDto = _mapper.Map<ReadAddressDto>(address);

        return Ok(addressDto);
      }
      return NotFound();
    }

    [HttpPut("{id}")]
    public IActionResult UpdateAddress(int id, [FromBody] UpdateAddressDto addressDto)
    {
      Address address = _context.Addresses.FirstOrDefault(address => address.Id == id);
      if (address == null)
      {
        return NotFound();
      }
      _mapper.Map(addressDto, address);
      _context.SaveChanges();
      return NoContent();
    }


    [HttpDelete("{id}")]
    public IActionResult DeleteAddress(int id)
    {
      Address address = _context.Addresses.FirstOrDefault(address => address.Id == id);
      if (address == null)
      {
        return NotFound();
      }
      _context.Remove(address);
      _context.SaveChanges();
      return NoContent();
    }

  }
}