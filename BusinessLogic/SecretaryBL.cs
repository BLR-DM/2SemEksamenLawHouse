using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityModels;
using UIModels;
using System.ComponentModel;

namespace BusinessLogic
{
    public class SecretaryBL
    {
        SecretaryDbAccess dbAccess;
        ModelConverter modelConverter;

        public SecretaryBL()
        {
            dbAccess = new SecretaryDbAccess();
            modelConverter = new ModelConverter();
        }

        public async Task<bool> CreateSecretaryAsync(SecretaryUI secretaryUI, LoginDetailsUI loginDetailsUI)
        {
            Secretary secretary = new Secretary();
            secretary = modelConverter.ConvertFromSecretaryUI(secretaryUI);
            secretary.LoginDetails = modelConverter.ConvertFromLoginDetailsUI(loginDetailsUI);
            return await dbAccess.CreateSecretaryAsync(secretary);
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
