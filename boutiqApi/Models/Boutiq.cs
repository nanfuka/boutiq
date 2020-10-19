using System.ComponentModel.DataAnnotations;

namespace boutiq.Models
{
    public class Boutiq
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int cost { get; set; }

    }
}