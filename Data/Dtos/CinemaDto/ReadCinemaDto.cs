
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using MoviesAPI.Models;

namespace MoviesAPI.Data.Dtos
{
  public class ReadCinemaDto
  {
    [Key]
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage = "Field name is mandatory")]
    public string Name { get; set; }

    public object Address { get; set; }
    public object Manager { get; set; }
  }
}
