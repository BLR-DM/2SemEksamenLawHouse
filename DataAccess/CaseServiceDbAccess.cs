using EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CaseServiceDbAccess
    {
        LawHouseDbContext db;
        public CaseServiceDbAccess()
        { 
            db = new LawHouseDbContext();
        }

        public async Task<List<CaseService>> GetCaseServicesAsync()
        {
            try
            {
                List<CaseService> caseServices = await db.CaseServices.ToListAsync();
                return caseServices;
            }
            catch (Exception)
            {

                return new List<CaseService>();
            }
        }



    }
}
