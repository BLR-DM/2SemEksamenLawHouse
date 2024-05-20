using DataAccess;
using EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIModels;
using BusinessLogic;
using Interfaces;

namespace BusinessLogic
{
    public class LawyerTitleBL
    {
        ILawyerTitleDbAccess dbAccess;
        ModelConverter modelConverter;
        public LawyerTitleBL()
        {
            dbAccess = new LawyerTitleDbAccess();
            modelConverter = new ModelConverter();
        }

        public async Task<List<LawyerTitleUI>> GetLawyerTitles()
        {
            List<LawyerTitle> lawyerTitles = await dbAccess.GetLawyerTitles();
            return lawyerTitles.Select(modelConverter.ConvertFromLawyerTitleEntity).ToList();
        }
    }
}
