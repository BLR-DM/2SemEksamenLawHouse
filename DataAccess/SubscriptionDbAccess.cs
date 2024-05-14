using EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class SubscriptionDbAccess
    {
        LawHouseDbContext db;
        public SubscriptionDbAccess()
        {
             db = new LawHouseDbContext();
        }

        public async Task<Subscription> GetSubscriptionAsync(int id)
        {
            try
            {
                return await db.Subscriptions.FirstOrDefaultAsync(s => s.SubscriptionID == id);
            }
            catch (Exception)
            {

                return new Subscription();
            }
            
        }

        public async Task<List<ClientSubscription>> GetClientSubscriptionsAsync(int clientID)
        {
            try
            {
                return await db.ClientSubscriptions.Where(cs => cs.ClientID == clientID).ToListAsync();
            }
            catch (Exception)
            {

                return new List<ClientSubscription>();
            }
        } 

        public async Task<bool> CreateSubscriptionAsync(ClientSubscription subscription)
        {
            try
            {
                await db.AddAsync(subscription);
                return await db.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {

                return false;
            }

        }

    }
}
