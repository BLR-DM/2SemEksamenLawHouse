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

    }
}
