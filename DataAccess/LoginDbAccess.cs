using EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class LoginDbAccess
    {
        LawHouseDbContext db;
        public LoginDbAccess()
        {
            db = new LawHouseDbContext();
        }

        public async Task<bool> CheckUsernameAsync(string username)
        {
            return await db.LoginDetails.AnyAsync(u => u.Username == username);

        }

        public async Task<int> CheckUsernameAndPasswordAsync(string username, string password)
        {
            //return await db.LoginDetails.AnyAsync(u => u.Username == username && u.Password == password);

            LoginDetails user = await db.LoginDetails.FirstOrDefaultAsync(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                return user.LoginDetailsID; 
            }
            return 0;

            //Person person = await db.Persons.FirstOrDefaultAsync(p => p.LoginDetailsID == id);


            //if (person is Client)
            //    return await db.Clients.FirstOrDefaultAsync(c => c.PersonID == person.PersonID);
            //return person;

        }

    }
}
