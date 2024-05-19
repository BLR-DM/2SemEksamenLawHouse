using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIModels;
using EntityModels;
using Interfaces;

namespace BusinessLogic
{
    public class ClientBL
    {
        IClientDbAccess dbAccess;
        ModelConverter modelConverter;
        public ClientBL()
        {
            dbAccess = new ClientDbAccessSqlClient();
            modelConverter = new ModelConverter();
        }

        public async Task<List<ClientUI>> GetClientsAsync()
        {
            List<ClientUI> clientUIs = new List<ClientUI>();
            foreach (Client c in await dbAccess.GetClientsAsync())
            {
                clientUIs.Add(modelConverter.ConvertFromClientEntity(c));
            }
            return clientUIs;
        }

        public async Task<ClientUI> GetClientAsync(int id)
        {
            Client client = await dbAccess.GetClientAsync(id);
            ClientUI clientUI = modelConverter.ConvertFromClientEntity(client);
            return clientUI;
        }

        // Get Telefonnumre
        public async Task<List<PhoneUI>> GetClientPhonesAsync(int id)
        {
            List<PhoneUI> phoneUIs = new List<PhoneUI>();
            foreach (Phone phone in await dbAccess.GetClientPhonesAsync(id))
            {
                phoneUIs.Add(modelConverter.ConvertFromPhoneEntity(phone));
            }
            return phoneUIs;
        }

        public async Task<bool> CreateClientAsync(ClientUI clientUI, LoginDetailsUI loginDetailsUI, List<PhoneUI> phoneUIs)
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


            return await dbAccess.CreateClientAsync(tempC);
        }

        public async Task<bool> UpdateClientAsync(ClientUI clientUI, List<PhoneUI> phoneUIs)
        {
            Client tempC = modelConverter.ConvertFromClientUI(clientUI);
            List<Phone> phoneList = new List<Phone>();

            foreach (PhoneUI phoneUI in phoneUIs)
            {
                Phone tmp = modelConverter.ConvertFromPhoneUI(phoneUI);
                phoneList.Add(tmp);

            }

            tempC.Phones = phoneList;

            return await dbAccess.UpdateClientAsync(tempC);
        }

        public async Task<bool> DeletePhoneNumbersAsync(List<PhoneUI> phoneNumbersUI)
        {
            List<Phone> phoneNumbers = new List<Phone>();
            foreach(PhoneUI phoneUI in phoneNumbersUI)
            {
                phoneNumbers.Add(modelConverter.ConvertFromPhoneUI(phoneUI));
            }
            return await dbAccess.DeleteClientPhoneNumbersAsync(phoneNumbers);
        }


    }
}
