using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRentalStore.Models
{
    public class Customers
    {
        public int id { get; set; }
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeid { get; set; }
    }
}