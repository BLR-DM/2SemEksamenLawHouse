using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using EntityModels;

namespace BusinessLogic
{
    public class LoginBL
    {
        LoginDbAccess dbAccess;
        ModelConverter modelConverter;

        public LoginBL()
        {
            dbAccess = new LoginDbAccess();
            modelConverter = new ModelConverter();
        }

        public async Task<bool> CheckUsernameAsync(string username)
        {
            return await dbAccess.CheckUsernameAsync(username);
        }

        public async Task<LoginDetails> CheckUsernameAndPasswordAsync(string username, string password)
        {
            return await dbAccess.CheckUsernameAndPasswordAsync(username, password);
        }
    }
}
