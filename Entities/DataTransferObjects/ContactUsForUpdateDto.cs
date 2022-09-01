using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public class ContactUsForUpdateDto
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string IsItAHomeOrBusiness { get; set; }
        public string Message { get; set; }
        public string HowDidYouHearAboutUs { get; set; }
        public string State { get; set; }
        public string Note { get; set; }
    }
}
