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
    public class ServicePriceTypeDbAccess : IServicePriceTypeDbAccess
    {
        LawHouseDbContext db;
        public ServicePriceTypeDbAccess()
        {
            db = new LawHouseDbContext();
        }

        public async Task<List<ServicePriceType>> GetServicePriceTypesAsync()
        {
            try
            {
                return await db.ServicePriceTypes.ToListAsync();
            }
            catch (Exception)
            {
                return new List<ServicePriceType>();
            }
        }
    }
}
