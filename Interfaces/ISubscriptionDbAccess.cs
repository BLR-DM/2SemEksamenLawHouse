using EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ISubscriptionDbAccess
    {
        Task<Subscription> GetSubscriptionAsync(int id);
        Task<List<ClientSubscription>> GetClientSubscriptionsAsync(int clientID);
        Task<bool> CreateSubscriptionAsync(ClientSubscription subscription);
    }
}
