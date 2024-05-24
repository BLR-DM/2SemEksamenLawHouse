using EntityModels;
using Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CaseTypeDbAccess : ICaseTypeDbAccess
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


        public async Task<bool> CreateCaseTypeAsync(CaseType caseType)
        {
            try
            {
                await db.CaseTypes.AddAsync(caseType);
                return await db.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> UpdateCaseTypeAsync(CaseType caseType)
        {
            try
            {
                db.CaseTypes.Update(caseType);
                return await db.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
