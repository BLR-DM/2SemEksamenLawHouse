using EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICaseTypeDbAccess
    {
        Task<bool> CreateCaseTypeAsync(CaseType caseType);
        Task<List<CaseType>> GetCaseTypeAsync();
    }
}
