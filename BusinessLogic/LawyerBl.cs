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
            try
            {
                Lawyer lawyer = await dbAccess.GetLawyerAsync(id);
                return modelConverter.ConvertFromLawyerEntity(lawyer);
            }
            catch (Exception)
            {
                return new LawyerUI();
            }
        }

        public async Task<List<LawyerUI>> GetLawyersAsync()
        {
            try
            {
                List<Lawyer> lawyers = await dbAccess.GetLawyersAsync();

                return lawyers.Select(modelConverter.ConvertFromLawyerEntity).ToList();
            }
            catch (Exception)
            {
                return new List<LawyerUI>();
            }
        }

        public async Task<List<LawyerUI>> GetLawyersWithCollectionsAsync()
        {
            try
            {
                List<Lawyer> lawyers = await dbAccess.GetLawyersWithCollectionsAsync();

                return lawyers.Select(modelConverter.ConvertFromLawyerEntityWithCollections).ToList();
            }
            catch (Exception)
            {
                return new List<LawyerUI>();
            }
        }
    }
}
