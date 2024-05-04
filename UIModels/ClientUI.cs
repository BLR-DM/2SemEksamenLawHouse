using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace UIModels
{
    public class ClientUI : PersonUI
    {

        //attributes
        public int ClientSub { get; set; } // 1 = True, 0 = False

        public virtual ICollection<PhoneUI> Phones { get; set; }
        public virtual ICollection<ClientFormularUI> ClientFormulars { get; set; }
        public virtual ICollection<CaseUI> Cases { get; set; }
        //0..1 Subscription
        public ClientSubscriptionUI ClientSubscription { get; set; }
    }
}
