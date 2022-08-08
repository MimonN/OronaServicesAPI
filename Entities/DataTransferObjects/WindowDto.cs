using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public class WindowDto
    {
        public int Id { get; set; }
        public string? WindowType { get; set; }
        public int OrderNumber { get; set; }
        public double RegularPrice { get; set; }
        public double ChemicalPrice { get; set; }
        public double PostConstructionPrice { get; set; }
        public string? ImgPath { get; set; }
    }
}
