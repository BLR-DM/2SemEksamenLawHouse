using EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    
    public class ClientDbAccess
    {
        LawHouseDbContext db;
        ConnectionStringSettingsCollection conn = ConfigurationManager.ConnectionStrings;
        string connString;
        public ClientDbAccess()
        {
            db = new LawHouseDbContext();

            //connectionstring Simply fra app.config
            connString = ConfigurationManager.ConnectionStrings["Simply"].ToString();
        }

        public async Task<List<Client>> GetClientsAsync()
        {
            try
            {
                List<Client> clients = await db.Clients
                    .Include(c => c.ClientSubscriptions)
                    .Include(c => c.Phones)
                    .ToListAsync();
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
                return await db.Clients
                    .Include(c => c.ClientSubscriptions)
                    .Include(c => c.Phones)
                    .FirstOrDefaultAsync(c => c.PersonID == id);

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
                bool success = await db.SaveChangesAsync() > 0;
                db.ChangeTracker.Clear();
                return success;
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

        //client phone numbers
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


        //SQL CLIENT
        //SQL CLIENT
        //SQL CLIENT
        public async Task<List<Client>> GetClientsAsyncSQLCLIENT()
        {
            try
            {
                List<Client> clients = await db.Clients
                    .Include(c => c.ClientSubscriptions)
                    .Include(c => c.Phones)
                    .ToListAsync();
                return clients;
            }
            catch (Exception)
            {

                return new List<Client>();
            }

            
        }

        public async Task<Client> GetClientAsyncSQLClient(int id)
        {
            try
            {
                return await db.Clients
                    .Include(c => c.ClientSubscriptions)
                    .Include(c => c.Phones)
                    .FirstOrDefaultAsync(c => c.PersonID == id);

            }
            catch (Exception)
            {

                return new Client();
            }
        }

        public async Task<bool> CreateClientAsyncSQLClient(Client client)
        {
            try
            {
                await db.AddAsync(client);
                bool success = await db.SaveChangesAsync() > 0;
                db.ChangeTracker.Clear();
                return success;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> UpdateClientAsyncSQLClient(Client client)
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

        //client phone numbers
        public async Task<List<Phone>> GetClientPhonesAsyncSQLClient(int id)
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

        public async Task<bool> DeleteClientPhoneNumbersAsyncSQLClient(List<Phone> phones)
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
