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

        public async Task<bool> CreateLawyerAsync(Lawyer lawyer)
        {
            await db.Lawyers.AddAsync(lawyer);
            bool result = await db.SaveChangesAsync() > 0;
            db.ChangeTracker.Clear();
            return result;
        }

        public async Task<Lawyer> GetLawyerAsync(int id)
        {
            return await db.Lawyers
                .Include(l => l.LawyerTitle)
                .SingleOrDefaultAsync(c => c.PersonID == id);
        }

        public async Task<Lawyer> GetLawyerWithCollectionsAsync(int id)
        {
            try
            {
                return await db.Lawyers
                        .Include(l => l.LawyerTitle)
                        .Include(c => c.Cases)
                                .ThenInclude(cs => cs.CaseServices)
                        .Include(l => l.CaseServices)
                        .SingleOrDefaultAsync(c => c.PersonID == id);
            }
            catch (Exception)
            {
                return new Lawyer();
            }
        }

        public async Task<List<Lawyer>> GetLawyersAsync()
        {
            try
            {
                List<Lawyer> lawyers = await db.Lawyers
                    .Include(l => l.LawyerTitle)
                    .ToListAsync();
                return lawyers;
            }
            catch (Exception)
            {
                return new List<Lawyer>();
            }
        }

        public async Task<List<Lawyer>> GetLawyersWithCollectionsAsync()
        {
            try
            {
                List<Lawyer> lawyers = await db.Lawyers
                    .Include(l => l.LawyerTitle)
                    .Include(c => c.Cases)
                        .ThenInclude(cs => cs.CaseServices)
                    .Include(l => l.CaseServices)
                    .Include(l => l.LawyerSpecialities)
                    .ToListAsync();
                return lawyers;

                
            }
            catch (Exception)
            {
                return new List<Lawyer>();
            }
        }


    }
}
