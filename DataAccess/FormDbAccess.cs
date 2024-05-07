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
                List<Form> form = db.Forms.ToList();
                return form;
            }
            catch (Exception)
            {

                return new List<Form>();
            }
        }
    }
}
