using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

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