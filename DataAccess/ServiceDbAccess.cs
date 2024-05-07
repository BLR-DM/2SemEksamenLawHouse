using EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ServiceDbAccess
    {
        LawHouseDbContext db;
        public ServiceDbAccess() 
        { 
            db = new LawHouseDbContext();
        }

        public async Task<List<Service>> GetServicesAsync()
        {
            try
            {
                List<Service> services = await db.Services.Include(s => s.ServicePriceType).ToListAsync();
                return services;
            }
            catch (Exception)
            {
                return new List<Service>();
            }
        }

        public async Task<List<Service>> GetServicesForCaseAsync(int caseID)
        {
            try
            {
                List<Service> servicesForCase = await db.CaseServices
                        .Where(cs => cs.CaseID == caseID)
                        .Include(cs => cs.Service)
                            .ThenInclude(s => s.ServicePriceType)
                        .Select(cs => cs.Service)
                        .ToListAsync();

                return servicesForCase;
            }
            catch (Exception)
            {

                return new List<Service>();
            }
        }

    }
}
