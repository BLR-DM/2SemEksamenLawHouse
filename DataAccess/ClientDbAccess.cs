using EntityModels;
using Microsoft.EntityFrameworkCore;
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
        
        public async Task<bool> CreateAsync(Client client)
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

        public async Task<Client> GetClientAsync(int id)
        {
            return await db.Clients.Include(c => c.Phones).FirstOrDefaultAsync(c => c.PersonID == id);
        }
    }
}
