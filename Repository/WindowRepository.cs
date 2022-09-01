using Contracts;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class WindowRepository : RepositoryBase<Window>, IWindowRepository
    {
        public WindowRepository(RepositoryContext repositoryContext) : base(repositoryContext) { }

        public async Task<IEnumerable<Window>> GetAllWindowsAsync()
        {
            return await FindAll().OrderBy(w => w.OrderNumber).ToListAsync();
        }

        public async Task<Window> GetWindowByIdAsync(int Id)
        {
            return await FindByCondition(w => w.Id.Equals(Id)).FirstOrDefaultAsync();
        }
        public void CreateWindow(Window window)
        {
            Create(window);
        }

        public void UpdateWindow(Window window)
        {
            Update(window);
        }

        public void DeleteWindow(Window window)
        {
            Delete(window);
        }
    }
}
