using EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols.Configuration;
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

        public async Task<List<Client>> GetClientsAsync()
        {
            try
            {
                List<Client> clients = db.Clients.Include(c => c.Phones).ToList();
                return clients;
            }
            catch (Exception)
            {

                return new List<Client>();
            }
        }

        public async Task<Client> GetClientAsync(int id)
        {
            try
            {
                return await db.Clients.Include(c => c.Phones).FirstOrDefaultAsync(c => c.PersonID == id);
            }
            catch (Exception)
            {

                return new Client();
            }
        }

        public async Task<bool> CreateClientAsync(Client client)
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
