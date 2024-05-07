using EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ClientFormDbAccess
    {
        LawHouseDbContext db;
        public ClientFormDbAccess()
        {
            db = new LawHouseDbContext();
        }

        public async Task<bool> BuyForm(ClientForm clientForm)
        {
            try
            {
                await db.ClientForms.AddAsync(clientForm);
                return db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
