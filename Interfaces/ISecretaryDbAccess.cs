using EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ISecretaryDbAccess
    {
        Task<bool> CreateSecretaryAsync(Secretary secretary);
        Task<List<Secretary>> GetSecretariesAsync();
    }
}
