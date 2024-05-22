using EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IServiceDbAccess
    {
        Task<bool> CreateServiceAsync(Service service);
        Task<List<Service>> GetServicesAsync();
        Task<Service> GetServiceAsync(int id);
        Task<List<Service>> GetServicesForCaseAsync(int caseID);
        Task<bool> UpdateServiceAsync(Service service);
        Task<bool> DeleteServiceAsync(Service service);
    }
}
