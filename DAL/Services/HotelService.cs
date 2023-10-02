using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
    public class HotelService : IHotelService
    {
        public Task<bool> CreateHotel(Hotel hotel)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteHotel(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Hotel>> GetAllHotels()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateHotel(int Id, Hotel hotel)
        {
            throw new NotImplementedException();
        }
    }
}
