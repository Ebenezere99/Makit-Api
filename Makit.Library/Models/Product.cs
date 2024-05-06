using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makit.Library.Models
{
    public class Product
    {
        [Key]
        [Required]
        [MaxLength(7)]
        [MinLength(7)]
        [RegularExpression(@"^[A-Z][A-Z][0-9][0-9][0-9][0-9][A-Z]*$")]
        public string? Reference { get; set; }


        [Required]
        [MinLength(7)]
        [MaxLength(37)]
        public string? Name { get; set; }

        [Required]
        public string? Description { get; set; }

        [Required]
        [MaxLength(5)]
        public string? Image { get; set; }
        
        [Required]
        [MaxLength(3)]
        [MinLength(3)]
        [RegularExpression(@"^[A-Z][0-9][0-9]*$")]
        public string? CategoryReference { get; set; }

        [Required]
        public ulong Quantity { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
       
        
    }
}
