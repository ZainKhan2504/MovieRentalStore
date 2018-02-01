using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRentalStore.Models
{
    public class Customers
    {
        public int id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public DateTime? Birthdate { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeid { get; set; }
    }
}