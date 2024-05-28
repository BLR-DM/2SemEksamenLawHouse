using EntityModels;
using Interfaces;
using Microsoft.EntityFrameworkCore;

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
                LoginDetails? user = await db.LoginDetails
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
                LoginDetails? tmp = await db.LoginDetails.FirstOrDefaultAsync(u => u.Username == username);
                
                return tmp != null ? tmp.Password : string.Empty;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

    }
}
