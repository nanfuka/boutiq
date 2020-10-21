using System.ComponentModel.DataAnnotations;


namespace boutiq.Models
{
    /**
 * this class include attributes of the shopped clothes
 * Attributes are id, type Description and cost, of which id is the primary key
 * Type of item added to the stalk such as leggings and tops
 * the cost of purchasing the item and the description
*/
    public class Boutiq
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the data type")]
        [StringLength(25)]
        [RegularExpression("^[a-zA-Z]*$")]
        public string Type { get; set; }
        [Required]
        [RegularExpression("^[a-zA-Z]*$")]
        public string Description { get; set; }
        [Required]
        [Range(2000, 100000)]
        public int cost { get; set; }


    }
}