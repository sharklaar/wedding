using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wedding.Models
{
    public class GuestList
    {
        public List<Guest> Guests { get; set; }
        public string Username { get; set; }
    }
}