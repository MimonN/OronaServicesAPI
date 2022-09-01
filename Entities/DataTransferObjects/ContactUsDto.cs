namespace Entities.DataTransferObjects
{
    public class ContactUsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string IsItAHomeOrBusiness { get; set; }
        public string Message { get; set; }
        public string HowDidYouHearAboutUs { get; set; }
        public string State { get; set; }
        public string Note { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? EditTime { get; set; }
    }
}
