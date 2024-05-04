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
    public class ClientBL
    {
        ClientDbAccess dbAccess;
        ModelConverter modelConverter;
        public ClientBL()
        {
            dbAccess = new ClientDbAccess();
            modelConverter = new ModelConverter();
        }
        //public async Task<bool> Create(Client client)
        //{
        //    return await dbAccess.CreateAsync(client);
        //}

        public async Task<bool> CreateAsync(ClientUI clientUI, LoginDetailsUI loginDetailsUI)
        {
            Client temp = modelConverter.ConvertFromClientUI(clientUI);
            LoginDetails tempL = modelConverter.ConvertFromLoginDetailsUI(loginDetailsUI);

            temp.LoginDetails = tempL;


            return await dbAccess.CreateAsync(temp);
        }
    }
}
