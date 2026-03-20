using Microsoft.EntityFrameworkCore;

namespace event_ease_applicatiion.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Models.Event> Events { get; set; }
        public DbSet<Models.Venue> Venues { get; set; }
        public DbSet<Models.Booking> Bookings { get; set; }
        public DbSet<Models.VenueType> VenueTypes { get; set; }
    }
}
