using EntityModels;
using Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CaseDbAccess : ICaseDbAccess
    {
        LawHouseDbContext db;
        public CaseDbAccess() 
        {
            db = new LawHouseDbContext();
        }

        public async Task<bool> CreateCaseAsync(Case caseE)
        {
            try
            {
                await db.Cases.AddAsync(caseE);
                bool succes = await db.SaveChangesAsync() > 0;
                db.ChangeTracker.Clear();
                return succes;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<Case> GetCaseAsync(int id)
        {
            try
            {
                return await db.Cases.FirstOrDefaultAsync(c => c.CaseID == id);
            }
            catch (Exception)
            {

                return new Case();
            }
        }

        public async Task<Case> GetCaseWithAllCollectionsAsync(int id)
        {
            try
            {
                Case caseE = await db.Cases
                    .Include(c => c.Lawyer)
                        .ThenInclude(l => l.LawyerTitle)
                    .Include(c => c.Client)
                        .ThenInclude(client => client.Phones)
                    .Include(c => c.CaseType)
                    .Include(c => c.CaseServices)
                        .ThenInclude(cs => cs.Service)
                            .ThenInclude(s => s.ServicePriceType)
                    .Include(c => c.CaseServices)
                        .ThenInclude(cs => cs.Lawyer)
                            .ThenInclude(l => l.LawyerTitle)
                    .Include(c => c.CaseServices)
                        .ThenInclude(cs => cs.ServiceEntries)
                    .FirstOrDefaultAsync(c => c.CaseID == id);
                return caseE;
            }
            catch (Exception)
            {
                return new Case();
            }
        }

        public async Task<List<Case>> GetCasesAsync()
        {
            try
            {
                List<Case> cases = await db.Cases.ToListAsync();
                return cases;
            }
            catch (Exception)
            {

                return new List<Case>();
            }
        }

        public async Task<List<Case>> GetCasesAsync(int ClientID)
        {
            try
            {
                return await db.Cases.Where(c => c.ClientID == ClientID).ToListAsync();
            }
            catch (Exception)
            {

                return new List<Case>();
            }
        }

        

        public async Task<bool> UpdateCaseAsync(Case caseE)
        {
            try
            {
                db.Cases.Update(caseE);
                bool succes = await db.SaveChangesAsync() > 0;
                db.ChangeTracker.Clear();
                return succes;  
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
