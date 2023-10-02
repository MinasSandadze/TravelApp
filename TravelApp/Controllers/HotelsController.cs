using DAL.Interfaces;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace TravelApp.Controllers
{
    public class HotelsController : ControllerBase
    {
        private readonly IHotelService _hotelService;

        public HotelsController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }

        [HttpGet("AllHotels")]
        public async Task<IEnumerable<Hotel>> GetAllHotels()
        {
            return await _hotelService.GetAllHotels();
        }

        [HttpPost("Create")]
        public async Task<bool> CreateHotel([FromBody]Hotel hotel)
        {
            return await _hotelService.CreateHotel(hotel);
        }

        [HttpDelete("Delete/{id}")]
        public async Task<bool> DeleteHotel([FromRoute]int id)
        {
            return await _hotelService.DeleteHotel(id);
        }

        [HttpPut("Modify/{id}")]
        public async Task<bool> UpdateHotel([FromRoute] int id, [FromBody]Hotel hotel)
        {
            return await _hotelService.UpdateHotel(id, hotel);
        }
    }
}
