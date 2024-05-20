using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EntityModels;
using Microsoft.EntityFrameworkCore;
using Interfaces;

namespace DataAccess
{
    public class FormDocumentDbAccess : IFormDocumentDbAccess
    {
        LawHouseDbContext db;
        public FormDocumentDbAccess()
        {
            db = new LawHouseDbContext();
        }
        public async Task<List<FormDocument>> GetFormDocumentsAsync()
        {
            try
            {
                List<FormDocument> forms = await db.FormDocuments.ToListAsync();
                return forms;
            }
            catch (Exception)
            {

                return new List<FormDocument>();
            }
        }

        public async Task<List<FormDocument>> GetBoughtFormDocumentsAsync(int clientID)
        {
            try
            {
                List<FormDocument> boughtForms = await db.ClientFormDocuments.Where(c => c.ClientID == clientID).Include(cf => cf.FormDocument).Select(cf => cf.FormDocument).ToListAsync();
                return boughtForms;
            }
            catch (Exception)
            {

                return new List<FormDocument>();
            }
        }

        public async Task<bool> CreateFormDocumentAsync(FormDocument form)
        {
            try
            {
                await db.FormDocuments.AddAsync(form);
                return await db.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public async Task<bool> UpdateFormDocumentAsync(FormDocument form)
        {
            try
            {
                db.FormDocuments.Update(form);
                return await db.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public async Task<bool> DeleteFormDocumentAsync(FormDocument form)
        {
            try
            {
                db.FormDocuments.Remove(form);
                return await db.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {

                return false;
            }

        }
    }
}
