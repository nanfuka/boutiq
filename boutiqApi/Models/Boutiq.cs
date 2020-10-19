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

        // public Boutiq(string _type, string _Description, int _cost)
        // {
        //     Type = _type;
        //     Description = _Description;
        //     cost = _cost;
        // }

    }
}