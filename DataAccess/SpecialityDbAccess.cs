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
    public class SpecialityDbAccess : ISpecialityDbAccess
    {
        LawHouseDbContext db;
        public SpecialityDbAccess() 
        { 
            db = new LawHouseDbContext();
        }

        public async Task<bool> CreateSpecialityAsync(Speciality speciality)
        {
            try
            {
                await db.AddAsync(speciality);
                bool result = await db.SaveChangesAsync() > 0;
                db.ChangeTracker.Clear();
                return result;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<Speciality>> GetSpecialitiesAsync()
        {
            return await db.Specialities.ToListAsync();
        }

        public async Task<List<LawyerSpeciality>> GetLawyerSpecialitiesAsync()
        {
            return await db.LawyerSpecialities
                .Include(x => x.Speciality)
                .ToListAsync();
        }

        public async Task<bool> UpdateSpecialityAsync(Speciality speciality)
        {
            try
            {
                db.Specialities.Update(speciality);
                bool result = await db.SaveChangesAsync() > 0;
                db.ChangeTracker.Clear();
                return result;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteSpecialityAsync(Speciality speciality)
        {
            try
            {
                db.Specialities.Remove(speciality);
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
