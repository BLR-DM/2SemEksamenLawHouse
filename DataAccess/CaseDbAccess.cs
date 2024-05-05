using EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CaseDbAccess
    {
        LawHouseDbContext db;
        public CaseDbAccess() 
        {
            db = new LawHouseDbContext();
        }

        public async Task<bool> CreateCase(Case caseE)
        {
            try
            {
                await db.AddAsync(caseE);
                return await db.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {

                return false;
            }
        }


    }
}
