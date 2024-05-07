using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIModels;
using EntityModels;

namespace BusinessLogic
{
    public class ClientFormBL
    {
        ClientFormDbAccess dbAccess;
        ModelConverter modelConverter;
        public ClientFormBL()
        {
            dbAccess = new ClientFormDbAccess();
            modelConverter = new ModelConverter();
        }

        public async Task<bool> BuyForm(ClientFormUI clientFormUI)
        {
            ClientForm clientForm = modelConverter.ConvertFromClientFormUI(clientFormUI);
            return await dbAccess.BuyForm(clientForm);
        }
    }
}
