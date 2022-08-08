using Entities.Models;

namespace Contracts
{
    public interface IWindowRepository : IRepositoryBase<Window>
    {
        Task<IEnumerable<Window>> GetAllWindowsAsync();
        Task<Window> GetWindowByIdAsync(int Id);
        void CreateWindow(Window window);
        void UpdateWindow(Window window);
        void DeleteWindow(Window window);
    }
}
