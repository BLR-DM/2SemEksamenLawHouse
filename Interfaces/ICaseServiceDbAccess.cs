using EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICaseServiceDbAccess
    {
        Task<bool> CreateCaseServiceAsync(CaseService caseService);
        Task<List<CaseService>> GetCaseServicesAsync(int id);
        Task<List<CaseService>> GetCaseServicesForLawyerAsync(int id);
        Task<bool> UpdateCaseServiceAsync(CaseService caseService);

    }
}
