using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class ContactUs
    {
        public int Id { get; set; }
        [Required]
        [StringLength(80, ErrorMessage = "The {0} must be at least {2} and no more than {1} characters long", MinimumLength = 2)]
        public string Name { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Address { get; set; }
        [Required]
        [StringLength(500, ErrorMessage = "The {0} must be at least {2} and no more than {1} characters long", MinimumLength = 2)]
        public string Message { get; set; }
        public string? HowDidYouHearAboutUs { get; set; }
        public string? IsItAHomeOrBusiness { get; set; }
        public string? State { get; set; }
        public string? Note { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? EditTime { get; set; }
    }
}
