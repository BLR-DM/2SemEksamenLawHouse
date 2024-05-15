using DataAccess;
using EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIModels;

namespace BusinessLogic
{
    public class SubscriptionBL
    {
        ModelConverter modelConverter;
        SubscriptionDbAccess dbAccess;

        public SubscriptionBL()
        {
            modelConverter = new ModelConverter();
            dbAccess = new SubscriptionDbAccess();
        }

        public async Task<SubscriptionUI> GetSubscriptionAsync(int id)
        {
            Subscription subcription = await dbAccess.GetSubscriptionAsync(id);
            SubscriptionUI subscriptionUI = modelConverter.ConvertFromSubscriptionEntity(subcription);
            return subscriptionUI;
            
        }

        public async Task<bool> CreateSubscriptionAsync(ClientSubscriptionUI subscriptionUI)
        {
            ClientSubscription clientSubscription = modelConverter.ConvertFromClientSubscriptionUI(subscriptionUI);
            return await dbAccess.CreateSubscriptionAsync(clientSubscription);
        }

        public async Task<List<ClientSubscriptionUI>> GetClientSubscriptionsAsync(int clientID)
        {
            List<ClientSubscription> clientSubscriptions = await dbAccess.GetClientSubscriptionsAsync(clientID);
            List<ClientSubscriptionUI> clientSubscriptionUIs = new List<ClientSubscriptionUI>();
            foreach (ClientSubscription clientSubscription in clientSubscriptions)
            {
                clientSubscriptionUIs.Add(modelConverter.ConvertFromClientSubscriptionEntity(clientSubscription));
            }
            return clientSubscriptionUIs;
        }


    }
}
