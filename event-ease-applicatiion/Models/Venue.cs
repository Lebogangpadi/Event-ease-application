using System.ComponentModel.DataAnnotations;

namespace event_ease_applicatiion.Models
{
    public class Venue
    {
        [Key]
        public int VenueId { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Location { get; set; }
        [Required]
        public int Capacity { get; set; }
        [Required]
        public string ImageURL { get; set; }
        public int VenueTypeId { get; set; }
        public VenueType? VenueType { get; set; }
        public List<Event>? Events { get; set; }
    }
}
