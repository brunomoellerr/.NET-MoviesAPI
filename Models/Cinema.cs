﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MoviesAPI.Models
{
    public class Cinema
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Field name is mandatory")]
        public string Name { get; set; }
        public virtual Address Address { get; set; }
        public int AddressId { get; set; }
        public virtual Manager Manager { get; set; }
        public int ManagerId { get; set; }
        [JsonIgnore]
        public virtual List<Session> Sessions { get; set; }

    }
}