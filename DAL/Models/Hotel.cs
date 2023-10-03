using DAL.Models.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Food Food { get; set; }

        public int CountOfRooms { get; set; }

        public string Address { get; set; }

        public HotelServices Services { get; set; }

        public double Rating { get; set; }

        public Stars Stars { get; set; }
    }
}