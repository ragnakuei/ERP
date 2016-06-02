using System.ComponentModel.DataAnnotations;

namespace ERP.Models
{
    public class Book
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string name { get; set; }
    }
}