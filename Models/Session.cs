using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.Models
{
    public class Session
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public virtual Cinema Cinema { get; set; }
        public virtual Movie Movie { get; set; }
        public int MovieId { get; set; }
        public int CinemaId { get; set; }
        public DateTime EndTime { get; set; }
    }
}