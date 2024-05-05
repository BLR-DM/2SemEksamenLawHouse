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

        public async Task<bool> CreateAsync(ClientUI clientUI, LoginDetailsUI loginDetailsUI, List<PhoneUI> phoneUIs)
        {
            Client tempC = modelConverter.ConvertFromClientUI(clientUI);
            LoginDetails tempL = modelConverter.ConvertFromLoginDetailsUI(loginDetailsUI);

            List<Phone> phoneList = new List<Phone>();

            foreach(PhoneUI phoneUI in phoneUIs)
            {
                Phone tmp = modelConverter.ConvertFromPhoneUI(phoneUI);
                phoneList.Add(tmp);
                
            }
            
            tempC.Phones = phoneList;
            tempC.LoginDetails = tempL;


            return await dbAccess.CreateAsync(tempC);
        }
    }
}
