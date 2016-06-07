using System.ComponentModel.DataAnnotations;

namespace Layout_Test.Models
{
    public class Book
    {
        [Key]
        [Required]
        public int id { get; set; }

        [Required]
        public string name { get; set; }
    }
}