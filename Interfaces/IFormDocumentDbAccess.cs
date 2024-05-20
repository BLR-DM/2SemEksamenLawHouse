using EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IFormDocumentDbAccess
    {
        Task<List<FormDocument>> GetFormDocumentsAsync();
        Task<List<FormDocument>> GetBoughtFormDocumentsAsync(int clientID);
        Task<bool> CreateFormDocumentAsync(FormDocument form);
        Task<bool> UpdateFormDocumentAsync(FormDocument form);
        Task<bool> DeleteFormDocumentAsync(FormDocument form);
    }
}
