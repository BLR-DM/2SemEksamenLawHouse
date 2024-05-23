using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIModels;
using EntityModels;
using Interfaces;
using BusinessLogic.HelpServices;

namespace BusinessLogic
{
    public class ClientFormDocumentBL
    {
        IClientFormDocumentDbAccess dbAccess;
        ModelConverter modelConverter;
        public ClientFormDocumentBL()
        {
            dbAccess = new ClientFormDocumentDbAccess();
            modelConverter = new ModelConverter();
        }

        public async Task<bool> BuyFormDocumentAsync(ClientFormDocumentUI clientFormUI)
        {
            ClientFormDocument clientForm = modelConverter.ConvertFromClientFormUI(clientFormUI);
            return await dbAccess.BuyFormDocumentAsync(clientForm);
        }
    }
}
