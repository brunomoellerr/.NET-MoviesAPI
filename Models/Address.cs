using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MoviesAPI.Models
{
    public class Address
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Street { get; set; }
        public string Neighbourhood { get; set; }
        public int Number { get; set; }
        [JsonIgnore]
        public virtual Cinema Cinema { get; set; }
  }
}