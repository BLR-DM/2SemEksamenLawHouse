using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityModels;
using UIModels;

namespace BusinessLogic
{
    public class LawyerBL
    {
        LawyerDbAccess dbAccess;
        ModelConverter modelConverter;
        public LawyerBL()
        {
            dbAccess = new LawyerDbAccess();
            modelConverter = new ModelConverter();
        }

        public bool CreateLawyer(Lawyer lawyer)
        {
            return dbAccess.CreateLawyer(lawyer);
        }
        public async Task<LawyerUI> GetLawyerAsync(int id)
        {
            Lawyer lawyer = await dbAccess.GetLawyerAsync(id);
            LawyerUI lawyerUI = modelConverter.ConvertFromLawyerEntity(lawyer);
            return lawyerUI;
        }

        public async Task<List<LawyerUI>> GetLawyersAsync()
        {
            List<LawyerUI> lawyerList = new List<LawyerUI>();
            foreach(Lawyer lawyer in await dbAccess.GetLawyersAsync())
            {
               lawyerList.Add(modelConverter.ConvertFromLawyerEntity(lawyer));
            }
            return lawyerList;
        }
    }
}
