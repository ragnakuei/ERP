using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Models
{
    public class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key,Column(Order = 1)]
        public Guid rowid { get; set; }

        [Key,Column(Order = 2)]
        public int id { get; set; }

        [Required]
        public string name { get; set; }
    }
}