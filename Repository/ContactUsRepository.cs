using Contracts;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class ContactUsRepository : RepositoryBase<ContactUs>, IContactUsRepository
    {
        public ContactUsRepository(RepositoryContext repositoryContext) : base(repositoryContext) { }

        public async Task<IEnumerable<ContactUs>> GetAllContactUsAsync()
        {
            return await FindAll().OrderBy(w => w.CreateTime).ToListAsync();
        }

        public async Task<ContactUs> GetContactUsAsync(int Id)
        {
            return await FindByCondition(w => w.Id.Equals(Id)).FirstOrDefaultAsync();
        }
        public void CreateContactUs(ContactUs contactUs)
        {
            Create(contactUs);
        }

        public void UpdateContactUs(ContactUs contactUs)
        {
            Update(contactUs);
        }

        public void DeleteContactUs(ContactUs contactUs)
        {
            Delete(contactUs);
        }
        
    }
}
