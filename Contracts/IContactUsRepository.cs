using Entities.Models;

namespace Contracts
{
    public interface IContactUsRepository : IRepositoryBase<ContactUs>
    {
        Task<IEnumerable<ContactUs>> GetAllContactUsAsync();
        Task<ContactUs> GetContactUsAsync(int Id);
        void CreateContactUs(ContactUs contactUs);
        void UpdateContactUs(ContactUs contactUs);
        void DeleteContactUs(ContactUs contactUs);
    }
}
