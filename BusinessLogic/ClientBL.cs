using DataAccess;
using EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ClientBL
    {
        ClientDbAccess clientDb;
        public ClientBL()
        {
            clientDb = new ClientDbAccess();
        }

        public async Task<bool> Create(Client client)
        {
            return await clientDb.Create(client);
        }

    }
}
