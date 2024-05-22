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
    public class ServiceDbAccess : IServiceDbAccess
    {
        LawHouseDbContext db;
        public ServiceDbAccess() 
        { 
            db = new LawHouseDbContext();
        }


        public async Task<bool> CreateServiceAsync(Service service)
        {
            try
            {
                await db.Services.AddAsync(service);
                return await db.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                return false;
            }
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

        public async Task<Service> GetServiceAsync(int id)
        {
            try
            {
                return await db.Services.Include(pt => pt.ServicePriceType).FirstOrDefaultAsync(s => s.ServiceID == id);
            }
            catch (Exception)
            {

                return new Service();
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

        public async Task<bool> UpdateServiceAsync(Service service)
        {
            try
            {
                db.Services.Update(service);
                return await db.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteServiceAsync(Service service)
        {
            try
            {
                db.Services.Remove(service);
                return await db.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
