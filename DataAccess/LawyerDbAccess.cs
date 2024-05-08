using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityModels;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class LawyerDbAccess
    {
        LawHouseDbContext db;
        public LawyerDbAccess()
        {
            db = new LawHouseDbContext();
        }

        public bool CreateLawyer(Lawyer lawyer)
        {
            db.Lawyers.Add(lawyer);

            return db.SaveChanges() > 0;
        }

        public async Task<Lawyer> GetLawyerAsync(int id)
        {
            return await db.Lawyers.Include(l => l.LawyerTitle).FirstOrDefaultAsync(c => c.PersonID == id);
        }

        public async Task<List<Lawyer>> GetLawyersAsync()
        {
            try
            {
                List<Lawyer> lawyers = await db.Lawyers.Include(l => l.LawyerTitle).ToListAsync();
                return lawyers;
            }
            catch (Exception)
            {
                return new List<Lawyer>();
            }
        }


    }
}
