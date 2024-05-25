using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIModels;

namespace Interfaces
{
    public interface IClientBL
    {
        Task<List<ClientUI>> GetClientsAsync();
        Task<ClientUI> GetClientAsync(int id);
        Task<List<PhoneUI>> GetClientPhonesAsync(int id);
        public Task<bool> CreateClientAsync(ClientUI clientUI, LoginDetailsUI loginDetailsUI, List<PhoneUI> phoneUIs);
        Task<bool> UpdateClientAsync(ClientUI clientUI, List<PhoneUI> phoneUIs);
        Task<bool> DeletePhoneNumbersAsync(List<PhoneUI> phoneNumbersUI);
    }
}
