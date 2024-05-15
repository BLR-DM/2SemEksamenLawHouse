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
                        .Include(l => l.LawyerSpecialities)
                            .ThenInclude(ls => ls.Speciality)
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
                        .ThenInclude(ls => ls.Speciality)
                    .ToListAsync();
                return lawyers;

                
            }
            catch (Exception)
            {
                return new List<Lawyer>();
            }
        }

        public async Task<bool> UpdateLawyerAsync(Lawyer lawyer)
        {
            try
            {
                db.Lawyers.Update(lawyer);
                bool result = await db.SaveChangesAsync() > 0;
                db.ChangeTracker.Clear();
                return result;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> UpdateLawyerSpecialitiesAsync(List<LawyerSpeciality> lawyerSpecialities)
        {
            try
            {
                db.LawyerSpecialities.AddRangeAsync(lawyerSpecialities);
                bool result = await db.SaveChangesAsync() > 0;
                db.ChangeTracker.Clear();
                return result;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteLawyerSpecialitiesAsync(List<LawyerSpeciality> lawyerSpecialities)
        {
            try
            {
                db.LawyerSpecialities.RemoveRange(lawyerSpecialities);
                bool result = await db.SaveChangesAsync() > 0;
                db.ChangeTracker.Clear();
                return result;
            }
            catch (Exception)
            {
                return false;
            }
        }


    }
}
