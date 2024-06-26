﻿using DataAccess;
using UIModels;
using EntityModels;
using Interfaces;
using BusinessLogic.HelpServices;
using BusinessLogic.Validation;

namespace BusinessLogic
{
    public class ClientBL : IClientBL
    {
        IClientDbAccess dbAccess;
        ModelConverter modelConverter;
        PersonValidator pValidator;
        public ClientBL()
        {
            dbAccess = new ClientDbAccessSqlClient();
            modelConverter = new ModelConverter();
            pValidator = new PersonValidator();
        }

        public async Task<List<ClientUI>> GetClientsAsync()
        {
            List<ClientUI> clientUIs = new List<ClientUI>();
            foreach (Client c in await dbAccess.GetClientsAsync())
            {
                clientUIs.Add(modelConverter.ConvertFromClientWithSubEntity(c));
            }
            return clientUIs;
        }

        public async Task<ClientUI> GetClientAsync(int id)
        {
            Client client = await dbAccess.GetClientAsync(id);
            ClientUI clientUI = modelConverter.ConvertFromClientWithSubEntity(client);
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
            if(!pValidator.ValidClient(clientUI))
            {
                return false;
            }

            foreach (PhoneUI phone in phoneUIs)
            {
                bool succes = pValidator.ValidPhone(phone.PhoneNumber.ToString());
                if (!succes)
                {
                    return false;
                }
            }

            if (!pValidator.ValidPassword(loginDetailsUI.Password))
            {
                return false;
            }

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
            if (!pValidator.ValidClient(clientUI))
            {
                return false;
            }

            foreach (PhoneUI phone in phoneUIs)
            {
                bool succes = pValidator.ValidPhone(phone.PhoneNumber.ToString());
                if (!succes)
                {
                    return false;
                }
            }

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
            foreach (PhoneUI phone in phoneNumbersUI)
            {
                bool succes = pValidator.ValidPhone(phone.PhoneNumber.ToString());
                if (!succes)
                {
                    return false;
                }
            }

            List<Phone> phoneNumbers = new List<Phone>();
            foreach(PhoneUI phoneUI in phoneNumbersUI)
            {
                phoneNumbers.Add(modelConverter.ConvertFromPhoneUI(phoneUI));
            }
            return await dbAccess.DeleteClientPhoneNumbersAsync(phoneNumbers);
        }
    }
}
