using System.ComponentModel.DataAnnotations;

namespace Event_MGT.Models
{
    public class Event
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public string Category { get; set; }

        public string ImageUrl { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Venue { get; set; }

        [Required]
        public decimal Price { get; set; }

        public int AvailableTickets { get; set; }
    }
}