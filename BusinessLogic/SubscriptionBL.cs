﻿using DataAccess;
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

        public async Task<bool> CreateSubscriptionAsync(ClientSubscriptionUI subscriptionUI)
        {
            ClientSubscription clientSubscription = modelConverter.ConvertFromClientSubscriptionUI(subscriptionUI);
            return await dbAccess.CreateSubscriptionAsync(clientSubscription);
        }

    }
}