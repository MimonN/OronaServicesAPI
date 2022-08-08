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
        public string? WindowType { get; set; }
        public int OrderNumber { get; set; }
        [Required]
        public double RegularPrice { get; set; }
        [Required]
        public double ChemicalPrice { get; set; }
        [Required]
        public double PostConstructionPrice { get; set; }
        [Required]
        public string? ImgPath { get; set; }
    }
}
