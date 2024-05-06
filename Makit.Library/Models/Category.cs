using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makit.Library.Models
{
    public class Category
    {
        [Key]
        [Required]
        [MaxLength(3)]
        [MinLength(3)]
        [RegularExpression(@"^[A-Z][0-9][0-9]*$")]
        public string? Reference { get; set; }

        [MinLength(7)]
        [MaxLength(37)]
        [Required]
        public string? Name { get; set; }
    }
}
