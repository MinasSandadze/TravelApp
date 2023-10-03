using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IHotelService
    {
        Task<bool> CreateHotel(Hotel hotel);

        Task<bool> UpdateHotel(int Id, Hotel hotel);

        Task<bool> DeleteHotel(int Id);

        Task<IEnumerable<Hotel>> GetAllHotels();
        Task<Hotel?> GetHotel(int id);
    }
}