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

namespace DataAccess
{
    public class FormDbAccess
    {
        LawHouseDbContext db;
        public FormDbAccess()
        {
            db = new LawHouseDbContext();
        }
        public async Task<List<Form>> GetFormsAsync()
        {
            try
            {
                List<Form> forms = await db.Forms.ToListAsync();
                return forms;
            }
            catch (Exception)
            {

                return new List<Form>();
            }
        }

        public async Task<List<Form>> GetBoughtFormsAsync(int clientID)
        {
            try
            {
                List<Form> boughtForms = await db.ClientForms.Where(c => c.ClientID == clientID).Include(cf => cf.Form).Select(cf => cf.Form).ToListAsync();
                return boughtForms;
            }
            catch (Exception)
            {

                return new List<Form>();
            }
        }
    }
}
