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
    public class CaseServiceDbAccess : ICaseServiceDbAccess
    {
        LawHouseDbContext db;
        public CaseServiceDbAccess()
        { 
            db = new LawHouseDbContext();
        }


        public async Task<bool> CreateCaseServiceAsync(CaseService caseService)
        {
            try
            {
                db.CaseServices.AddAsync(caseService);
                bool succes = db.SaveChanges() > 0;
                db.ChangeTracker.Clear();
                return succes;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<List<CaseService>> GetCaseServicesAsync(int id)
        {
            try
            {
                List<CaseService> caseServices = await db.CaseServices
                            .Where(cs => cs.CaseID == id)
                            .Include(s => s.Service)
                                .ThenInclude(s => s.ServicePriceType)
                            .ToListAsync();
                return caseServices;
            }
            catch (Exception)
            {

                return new List<CaseService>();
            }
        }

        public async Task<List<CaseService>> GetCaseServicesForLawyerAsync(int id)
        {
            try
            {
                List<CaseService> caseServices = await db.CaseServices
                            .Where(cs => cs.LawyerID == id)
                            .Include(s => s.Service)
                                .ThenInclude(s => s.ServicePriceType)
                            .ToListAsync();
                return caseServices;
            }
            catch (Exception)
            {

                return new List<CaseService>();
            }
        }

        public async Task<bool> UpdateCaseServiceAsync(CaseService caseService)
        {
            try
            {
                db.CaseServices.Update(caseService);
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
