using EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICaseDbAccess
    {
        Task<bool> CreateCaseAsync(Case caseE);
        Task<Case> GetCaseAsync(int id);
        Task<Case> GetCaseWithAllCollectionsAsync(int id);
        Task<List<Case>> GetCasesAsync();
        Task<List<Case>> GetCasesAsync(int ClientID);
        Task<bool> UpdateCaseAsync(Case caseE);

    }
}
