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
    public class FormularDbAccess
    {
        LawHouseDbContext db;
        public FormularDbAccess()
        {
            db = new LawHouseDbContext();
        }
        public async Task<List<Formular>> GetFormularsAsync()
        {
            try
            {
                List<Formular> formulars = db.Formulars.ToList();
                return formulars;
            }
            catch (Exception)
            {

                return new List<Formular>();
            }
        }
    }
}
