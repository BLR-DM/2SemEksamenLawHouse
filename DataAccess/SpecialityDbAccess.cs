using EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class SpecialityDbAccess
    {
        LawHouseDbContext db;
        public SpecialityDbAccess() 
        { 
            db = new LawHouseDbContext();
        }

        public async Task<List<Speciality>> GetSpecialitiesAsync()
        {
            return await db.Specialities.ToListAsync();
        }

        public async Task<List<LawyerSpeciality>> GetLawyerSpecialitiesAsync()
        {
            return await db.LawyerSpeciality.ToListAsync();
        }
    }
}
