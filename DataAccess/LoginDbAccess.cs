﻿using EntityModels;
using Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class LoginDbAccess : ILoginDbAccess
    {
        LawHouseDbContext db;
        public LoginDbAccess()
        {
            db = new LawHouseDbContext();
        }

        public async Task<int> CheckUsernameAndPasswordAsync(string username, string password)
        {
            try
            {
                LoginDetails user = await db.LoginDetails
                        .FirstOrDefaultAsync(u => u.Username == username && u.Password == password);

                return user != null ? user.LoginDetailsID : 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public async Task<string> RetrievePasswordAsync(string username)
        {
            try
            {
                LoginDetails tmp = await db.LoginDetails.FirstOrDefaultAsync(u => u.Username == username);
                
                return tmp.Password;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

    }
}
