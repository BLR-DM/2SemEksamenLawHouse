﻿using EntityModels;
using Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class LawyerTitleDbAccess : ILawyerTitleDbAccess
    {
        LawHouseDbContext db;
        public LawyerTitleDbAccess()
        {
            db = new LawHouseDbContext();
        }

        public async Task<bool> CreateLawyerTitleAsync(LawyerTitle title)
        {
            try
            {
                await db.LawyerTitles.AddAsync(title);
                bool result = await db.SaveChangesAsync() > 0;
                db.ChangeTracker.Clear();
                return result;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<LawyerTitle>> GetLawyerTitles()
        {
            try
            {
                return await db.LawyerTitles.ToListAsync();
            }
            catch (Exception)
            {
                return new List<LawyerTitle>();
            }
        }

        public async Task<bool> UpdateLawyerTitleAsync(LawyerTitle lawyerTitle)
        {
            try
            {
                db.LawyerTitles.Update(lawyerTitle);
                bool result = await db.SaveChangesAsync() > 0;
                db.ChangeTracker.Clear();
                return result;
            }
            catch (Exception)
            {
                return false;
            };
        }
    }
}
