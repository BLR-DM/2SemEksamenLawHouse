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
    public class ClientFormDocumentBL
    {
        ClientFormDocumentDbAccess dbAccess;
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
