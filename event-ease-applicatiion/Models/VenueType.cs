using System.ComponentModel.DataAnnotations;

namespace event_ease_applicatiion.Models
{
    public class VenueType
    {
        [Key]
        public int TypeId { get; set; }
        [Required]
        public string? Name { get; set; }
    }
}
