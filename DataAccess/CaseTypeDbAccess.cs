using EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CaseTypeDbAccess
    {
        LawHouseDbContext db;
        public CaseTypeDbAccess() 
        {
            db = new LawHouseDbContext();
        }

        public async Task<List<CaseType>> GetCaseTypeAsync()
        {
            return await db.CaseTypes.ToListAsync();
        }
    }
}
