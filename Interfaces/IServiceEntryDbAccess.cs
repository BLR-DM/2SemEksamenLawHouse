using EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IServiceEntryDbAccess
    {
        Task<bool> CreateServiceEntryAsync(ServiceEntry serviceEntry);
        Task<List<ServiceEntry>> GetServiceEntriesAsync(int id);
    }
}
