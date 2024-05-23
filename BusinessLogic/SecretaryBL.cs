using BusinessLogic.HelpServices;
using DataAccess;
using EntityModels;
using Interfaces;
using UIModels;

namespace BusinessLogic
{
    public class SecretaryBL
    {
        ISecretaryDbAccess dbAccess;
        ModelConverter modelConverter;

        public SecretaryBL()
        {
            dbAccess = new SecretaryDbAccess();
            modelConverter = new ModelConverter();
        }

        public async Task<bool> CreateSecretaryAsync(SecretaryUI secretaryUI, LoginDetailsUI loginDetailsUI)
        {
            try
            {
                Secretary secretary = new Secretary();
                secretary = modelConverter.ConvertFromSecretaryUI(secretaryUI);
                secretary.LoginDetails = modelConverter.ConvertFromLoginDetailsUI(loginDetailsUI);
                return await dbAccess.CreateSecretaryAsync(secretary);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<SecretaryUI>> GetSecretariesAsync()
        {
            try
            {
                List<Secretary> secretaries = await dbAccess.GetSecretariesAsync();
                return secretaries.Select(modelConverter.ConvertFromSecretaryEntity).ToList();
            }
            catch (Exception)
            {
                return new List<SecretaryUI>();
            }
        }




    }
}
