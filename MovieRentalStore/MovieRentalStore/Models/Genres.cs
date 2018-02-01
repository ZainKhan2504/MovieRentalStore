﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRentalStore.Models
{
    public class Genres
    {
        public byte id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}