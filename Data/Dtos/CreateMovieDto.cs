using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.Data.Dtos
{
  public class CreateMovieDto
  {
    [Required(ErrorMessage = "Title field is mandatory")]
    public string Title { get; set; }

    [Required(ErrorMessage = "Director field is mandatory")]
    public string Director { get; set; }

    [StringLength(30, ErrorMessage = "Genre cannot be bigger than 30 characters")]
    public string Genre { get; set; }

    [Range(1, 600, ErrorMessage = "Duration must be between 1 and 600 minutes")]
    public int Duration { get; set; }
  }
}