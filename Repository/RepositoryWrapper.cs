using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private RepositoryContext _repoContext;
        private IWindowRepository _window;
        private IContactUsRepository _contactUs;

        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }
        public IWindowRepository Window
        {
            get
            {
                if(_window == null)
                {
                    _window = new WindowRepository(_repoContext);
                }

                return _window;
            }
        }

        public IContactUsRepository ContactUs
        {
            get
            {
                if(_contactUs == null)
                {
                    _contactUs = new ContactUsRepository(_repoContext);
                }

                return _contactUs;
            }
        }

        public async Task SaveAsync()
        {
            await _repoContext.SaveChangesAsync();
        }
    }
}
