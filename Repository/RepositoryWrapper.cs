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

        public async Task SaveAsync()
        {
            await _repoContext.SaveChangesAsync();
        }
    }
}
