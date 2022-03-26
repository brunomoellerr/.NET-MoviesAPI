using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using MoviesAPI.Models;

namespace MoviesAPI.Data.Dtos
{
    public class ReadManagerDto
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public object Cinemas { get; set; }

  }
}