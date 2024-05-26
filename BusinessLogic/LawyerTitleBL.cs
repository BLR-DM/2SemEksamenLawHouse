using DataAccess;
using EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIModels;
using Interfaces;
using BusinessLogic.HelpServices;

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

        public async Task<bool> CreateLawyerTitleAsync(LawyerTitleUI titleUI)
        {
            try
            {
                LawyerTitle title = modelConverter.ConvertFromLawyerTitleUI(titleUI);
                return await dbAccess.CreateLawyerTitleAsync(title);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<LawyerTitleUI>> GetLawyerTitles()
        {
            try
            {
                List<LawyerTitle> lawyerTitles = await dbAccess.GetLawyerTitles();
                return lawyerTitles.Select(modelConverter.ConvertFromLawyerTitleEntity).ToList();
            }
            catch (Exception)
            {
                return new List<LawyerTitleUI>();
            }
        }

        public async Task<bool> UpdateLawyerTitleAsync(LawyerTitleUI lawyerTitleUI)
        {
            try
            {
                LawyerTitle lawyerTitle = modelConverter.ConvertFromLawyerTitleUI(lawyerTitleUI);
                return await dbAccess.UpdateLawyerTitleAsync(lawyerTitle);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteLawyerTitleAsync(LawyerTitleUI lawyerTitleUI)
        {
            try
            {
                LawyerTitle lawyerTitle = modelConverter.ConvertFromLawyerTitleUI(lawyerTitleUI);
                return await dbAccess.DeleteLawyerTitleAsync(lawyerTitle);
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
