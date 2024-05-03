using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityModels;

namespace DataAccess
{
    public class LawyerDbAccess
    {
        LawHouseDbContext db;
        public LawyerDbAccess()
        {
            db = new LawHouseDbContext();
        }

        public bool CreateLawyer(Lawyer lawyer)
        {
            db.Lawyers.Add(lawyer);
            db.SaveChanges();
            return true;
        }
    }
}
