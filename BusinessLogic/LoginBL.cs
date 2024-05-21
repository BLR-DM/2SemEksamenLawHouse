﻿using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using EntityModels;
using Interfaces;

namespace BusinessLogic
{
    public class LoginBL
    {
        ILoginDbAccess dbAccess;

        public LoginBL()
        {
            dbAccess = new LoginDbAccess();
        }

        public async Task<bool> CheckUsernameAsync(string username)
        {
            return await dbAccess.CheckUsernameAsync(username);
        }

        public async Task<int> CheckUsernameAndPasswordAsync(string username, string password)
        {
            return await dbAccess.CheckUsernameAndPasswordAsync(username, password);
        }

        public async Task<string> RetrievePasswordAsync(string username)
        {
            return await dbAccess.RetrievePasswordAsync(username);
        }
    }
}
