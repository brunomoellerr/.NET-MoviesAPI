using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoviesAPI.Models;

namespace MoviesAPI.Data.Dtos
{
    public class ReadSessionDto
    {   
        public int Id { get; set; }
        public Cinema Cinema { get; set; }
        public Movie Movie { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime StartTime { get; set; }
    
    }
}