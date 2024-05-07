using EntityModels;
using Microsoft.EntityFrameworkCore;
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
                await db.Cases.AddAsync(caseE);
                return await db.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<List<Case>> GetCasesAsync()
        {
            try
            {
                List<Case> cases = await db.Cases.ToListAsync();
                return cases;
            }
            catch (Exception)
            {

                return new List<Case>();
            }
        }
    }
}
