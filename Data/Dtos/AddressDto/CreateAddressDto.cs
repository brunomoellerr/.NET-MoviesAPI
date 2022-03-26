using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Data.Dtos
{
    public class CreateAddressDto
    {
        public string Street { get; set; }
        public string Neighbourhood { get; set; }
        public int Number { get; set; }
    }
}