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
                List<Client> clients = await db.Clients.Include(c => c.Phones).ToListAsync();
                return clients;
            }
            catch (Exception)
            {

                return new List<Client>();
            }
        }

        public async Task<List<Phone>> GetClientPhonesAsync(int id)
        {
            try
            {
                List<Phone> phones = await db.Phones.Where(p => p.ClientID == id).ToListAsync();
                return phones;
            }
            catch (Exception)
            {

                return new List<Phone>();
            }
        }

        public async Task<Client> GetClientAsync(int id)
        {
            try
            {
                return await db.Clients
                    .Where(c => c.PersonID == id)
                    .Include(c => c.Phones)
                    .FirstOrDefaultAsync();

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

        public async Task<bool> UpdateClientAsync(Client client)
        {
            try
            {
                db.Clients.Update(client);
                bool success = await db.SaveChangesAsync() > 0;
                db.ChangeTracker.Clear();
                return success;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteClientPhoneNumbersAsync(List<Phone> phones)
        {
            try
            {
                db.Phones.RemoveRange(phones);
                bool success = await db.SaveChangesAsync() > 0;
                db.ChangeTracker.Clear();
                return success;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
