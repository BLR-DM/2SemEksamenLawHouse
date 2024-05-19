using EntityModels;
namespace Interfaces
{
    public interface IClientDbAccess
    {
        Task<bool> CreateClientAsync(Client client);
        Task<List<Client>> GetClientsAsync();
        Task<Client> GetClientAsync(int id);
        Task<List<Phone>> GetClientPhonesAsync(int ClientID);
        Task<bool> UpdateClientAsync(Client client);
        Task<bool> DeleteClientPhoneNumbersAsync(List<Phone> phones);
    }
}
