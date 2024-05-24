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
        Task<List<CaseType>> GetCaseTypeAsync();
        Task<bool> CreateCaseTypeAsync(CaseType caseType);
    }
}
