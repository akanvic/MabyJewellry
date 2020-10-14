using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MabyJewelrry.Model
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string  Name { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        [Required]
        public int CategoryId { get; set; }
        public string ImageUrl { get; set; }

        [Required]
        [Range(1, 100000)]
        public double Price { get; set; }
        public string Description { get; set; }
    }
}
