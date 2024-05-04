using EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    
    public class ClientDbAccess
    {
        LawHouseDbContext db;
        public ClientDbAccess()
        {
            db = new LawHouseDbContext();
        }
        
        public async Task<bool> Create(Client client)
        {
            try
            {
                await db.AddAsync(client);
                return await db.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
