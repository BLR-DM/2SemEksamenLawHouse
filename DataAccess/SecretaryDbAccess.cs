using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using EntityModels;
using Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{    
    public class SecretaryDbAccess : ISecretaryDbAccess
    {
        LawHouseDbContext db;
        public SecretaryDbAccess() 
        {
            db = new LawHouseDbContext(); 
        }

        public async Task<bool> CreateSecretaryAsync(Secretary secretary)
        {
            try
            {
                await db.Secretaries.AddAsync(secretary);
                bool result = await db.SaveChangesAsync() > 0;
                db.ChangeTracker.Clear();
                return result;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        public async Task<List<Secretary>> GetSecretariesAsync()
        {
            try
            {
                return await db.Secretaries
                    .Include(l => l.LawyerTitle)
                    .ToListAsync();
            }
            catch (Exception)
            {
                return new List<Secretary>();
            }
        }
    }
}
