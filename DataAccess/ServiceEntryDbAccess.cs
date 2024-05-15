﻿using EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ServiceEntryDbAccess
    {
        LawHouseDbContext db;
        public ServiceEntryDbAccess()
        {
            db = new LawHouseDbContext();
        }

        public async Task<bool> CreateServiceEntryAsync(ServiceEntry serviceEntry)
        {
            try
            {
                db.ServiceEntries.AddAsync(serviceEntry);
                return await db.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<List<ServiceEntry>> GetServiceEntriesAsync(int id)
        {
            try
            {
                List<ServiceEntry> serviceEntries = await db.ServiceEntries.Where(cs => cs.CaseServiceID == id).ToListAsync();
                return serviceEntries;
            }
            catch (Exception)
            {

                return new List<ServiceEntry>();
            }
        }
    }
}