using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryWrapper
    {
        IWindowRepository Window { get; }
        IContactUsRepository ContactUs { get; }
        Task SaveAsync();
    }
}
