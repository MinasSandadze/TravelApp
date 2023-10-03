using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models.Helpers;

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

        private IEnumerable<Hotel> GetHotels()
        {
            var hotels = new List<Hotel>
            {
                new Hotel()
                {
                    Address = "Yerevan",
                    CountOfRooms = 10,
                    Food = new Food()
                    {
                        Name = "Food1",
                        Description = "Description",
                    },
                    Stars = Stars.Five,
                    Name = "Multy"
                },
                new Hotel()
                {
                    Address = "Hrazdan",
                    CountOfRooms = 20,
                    Food = new Food()
                    {
                        Name = "Djarit",
                        Description = "Description2",
                    },
                    Stars = Stars.Five,
                    Name = "Hotel In Hrazdan"
                }
            };
            return hotels;
        }

        public Task<Hotel?> GetHotel(int id)
        {
            var hotels = GetHotels();
            Hotel? result = null;
            foreach (var hotel in hotels)
            {
                if (hotel.Id == id)
                {
                    result = hotel;
                    break;
                }
            }

            return Task.FromResult<Hotel?>(result);
        }

        public Task<IEnumerable<Hotel>> GetAllHotels()
        {
            var hotels = new List<Hotel>
            {
                new Hotel()
                {
                    Address = "Yerevan",
                    CountOfRooms = 10,
                    Food = new Food()
                    {
                        Name = "Food1",
                        Description = "Description",
                    },
                    Stars = Stars.Five,
                    Name = "Multy"
                },
                new Hotel()
                {
                    Address = "Hrazdan",
                    CountOfRooms = 20,
                    Food = new Food()
                    {
                        Name = "Djarit",
                        Description = "Description2",
                    },
                    Stars = Stars.Five,
                    Name = "Hotel In Hrazdan"
                }
            };
            return Task.FromResult<IEnumerable<Hotel>>(hotels);
        }

        public Task<bool> UpdateHotel(int Id, Hotel hotel)
        {
            throw new NotImplementedException();
        }
    }
}