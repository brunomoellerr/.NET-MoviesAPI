using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.Data.Dtos
{
    public class CreateSessionDto
    {
        public int CinemaId { get; set; }
        public int MovieId { get; set; }
        public DateTime EndTime { get; set; }
    }
}