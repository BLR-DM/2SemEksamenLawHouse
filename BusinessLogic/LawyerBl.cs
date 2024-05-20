using DataAccess;
using EntityModels;
using Interfaces;
using UIModels;

namespace BusinessLogic
{
    public class LawyerBL
    {
        ILawyerDbAccess dbAccess;
        ModelConverter modelConverter;
        public LawyerBL()
        {
            dbAccess = new LawyerDbAccess();
            modelConverter = new ModelConverter();
        }

        public async Task<bool> CreateLawyerAsync(LawyerUI lawyerUI, List<LawyerSpecialityUI> lawyerSpecialityUIs, LoginDetailsUI loginDetailsUI)
        {
            Lawyer lawyer = modelConverter.ConvertFromLawyerUI(lawyerUI);
            List<LawyerSpeciality> lawyerSpecialities = lawyerSpecialityUIs
                .Select(modelConverter.ConvertFromLawyerSpecialityUI).ToList();
            LoginDetails loginDetails = modelConverter.ConvertFromLoginDetailsUI(loginDetailsUI);

            lawyer.LawyerSpecialities = lawyerSpecialities;
            lawyer.LoginDetails = loginDetails;

            return await dbAccess.CreateLawyerAsync(lawyer);
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

        public async Task<LawyerUI> GetLawyerWithCollectionsAsync(int id)
        {
            try
            {
                Lawyer lawyer = await dbAccess.GetLawyerWithCollectionsAsync(id);
                return modelConverter.ConvertFromLawyerEntityWithCollections(lawyer);
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

        public async Task<bool> UpdateLawyerAsync(LawyerUI lawyerUI)
        {
            try
            {
                Lawyer lawyer = modelConverter.ConvertFromLawyerUI(lawyerUI);
                //lawyer.Cases = lawyerUI.Cases.Select(modelConverter.ConvertFromCaseUI).ToList();
                //lawyer.CaseServices = lawyerUI.CaseServices.Select(modelConverter.ConvertFromCaseServiceUI).ToList();
                return await dbAccess.UpdateLawyerAsync(lawyer);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> UpdateLawyerSpecialitiesAsync(List<LawyerSpecialityUI> updatedLawyerSpecialities)
        {
            List<LawyerSpeciality> lawyerSpecialities = updatedLawyerSpecialities
                .Select(modelConverter.ConvertFromLawyerSpecialityUI).ToList();
            return await dbAccess.UpdateLawyerSpecialitiesAsync(lawyerSpecialities);
        }

        public async Task<bool> DeleteLawyerSpecialitiesAsync(List<LawyerSpecialityUI> deletedLawyerSpecialities)
        {
            List<LawyerSpeciality> lawyerSpecialities = deletedLawyerSpecialities
                .Select(modelConverter.ConvertFromLawyerSpecialityUI).ToList();
            return await dbAccess.DeleteLawyerSpecialitiesAsync(lawyerSpecialities);
        }
    }
}
