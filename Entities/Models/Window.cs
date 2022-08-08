using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Window
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Window Type")]
        public string WindowType { get; set; }
        public int OrderNumber { get; set; }
        [Required]
        [Display(Name = "Regular")]
        public double RegularPrice { get; set; }
        [Required]
        [Display(Name = "Chemical")]
        public double ChemicalPrice { get; set; }
        [Required]
        [Display(Name = "Post-Construction")]
        public double PostConstructionPrice { get; set; } 
    }
}
