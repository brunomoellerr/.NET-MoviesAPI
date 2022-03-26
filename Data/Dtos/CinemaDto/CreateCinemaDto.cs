﻿using MoviesAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.Data.Dtos
{
    public class CreateCinemaDto
    {
        [Required(ErrorMessage = "Field name is mandatory")]
        public string Name { get; set; }
        public int AddressId { get; set; }
        public int ManagerId { get; set; }
  }
}
