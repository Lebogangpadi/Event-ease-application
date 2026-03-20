using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace event_ease_applicatiion.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }
        public int VenueId { get; set; }

        [Required, MaxLength(200)]
        public string EventName { get; set; } = null!;

        public DateTime EventDate { get; set; }

        public string? Description { get; set; }

        [Required]
        public string? ImageUrl { get; set; }
       
        [ForeignKey(nameof(VenueId))]
        public Venue? Venue { get; set; }

        public ICollection<Booking> Bookings { get; set; } = new HashSet<Booking>();

        

    }
}
