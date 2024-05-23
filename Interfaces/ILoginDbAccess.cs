using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ILoginDbAccess
    {
        Task<int> CheckUsernameAndPasswordAsync(string username, string password);
        Task<string> RetrievePasswordAsync(string username);
    }
}
