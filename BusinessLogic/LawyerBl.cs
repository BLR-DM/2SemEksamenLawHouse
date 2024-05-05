using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityModels;

namespace BusinessLogic
{
    public class LawyerBL
    {
        LawyerDbAccess dbAccess;
        public LawyerBL()
        {
            dbAccess = new LawyerDbAccess();
        }

        public bool CreateLawyer(Lawyer lawyer)
        {
            return dbAccess.CreateLawyer(lawyer);
        }
    }
}
