using EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class LawyerTitleDbAccess
    {
        LawHouseDbContext db;
        public LawyerTitleDbAccess()
        {
            db = new LawHouseDbContext();
        }

        public async Task<List<LawyerTitle>> GetLawyerTitles()
        {
            return await db.LawyerTitles.ToListAsync();
        }
    }
}
