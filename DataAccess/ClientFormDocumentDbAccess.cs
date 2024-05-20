using EntityModels;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ClientFormDocumentDbAccess : IClientFormDocumentDbAccess
    {
        LawHouseDbContext db;
        public ClientFormDocumentDbAccess()
        {
            db = new LawHouseDbContext();
        }

        public async Task<bool> BuyFormDocumentAsync(ClientFormDocument clientForm)
        {
            try
            {
                await db.ClientFormDocuments.AddAsync(clientForm);
                return db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
