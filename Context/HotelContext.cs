using HotelBookingApi.Entities;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace HotelBookingApi.Context
{
    public class HotelContext : DbContext
    {
        public HotelContext(DbContextOptions<HotelContext> options) : base(options)
        { }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }
}
