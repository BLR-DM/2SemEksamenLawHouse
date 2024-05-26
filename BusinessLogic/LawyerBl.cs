using BusinessLogic.HelpServices;
using BusinessLogic.Validation;
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
        PersonValidator pValidator;
        public LawyerBL()
        {
            dbAccess = new LawyerDbAccess();
            modelConverter = new ModelConverter();
            pValidator = new PersonValidator();
        }

        public async Task<bool> CreateLawyerAsync(LawyerUI lawyerUI, List<LawyerSpecialityUI> lawyerSpecialityUIs, LoginDetailsUI loginDetailsUI)
        {
            if (!pValidator.ValidEmployee(lawyerUI) || !pValidator.ValidLogin(loginDetailsUI) || lawyerSpecialityUIs == null)
                return false;

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
            if (id > 0)
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
            return new LawyerUI();
        }

        public async Task<LawyerUI> GetLawyerWithCollectionsAsync(int id)
        {
            if (id > 0)
            {
                try
                {
                    Lawyer lawyer = await dbAccess.GetLawyerWithCollectionsAsync(id);
                    return modelConverter.ConvertFromLawyerEntityWithAllCollections(lawyer);
                }
                catch (Exception)
                {
                    return new LawyerUI();
                }
            }
            return new LawyerUI();
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
            if (pValidator.ValidEmployee(lawyerUI))
            {
                try
                {
                    Lawyer lawyer = modelConverter.ConvertFromLawyerUI(lawyerUI);
                    return await dbAccess.UpdateLawyerAsync(lawyer);
                }
                catch (Exception)
                {
                    return false;
                } 
            }
            return false;
        }

        public async Task<bool> UpdateLawyerSpecialitiesAsync(List<LawyerSpecialityUI> updatedLawyerSpecialities)
        {
            if (updatedLawyerSpecialities != null)
            {
                try
                {
                    List<LawyerSpeciality> lawyerSpecialities = updatedLawyerSpecialities
                                    .Select(modelConverter.ConvertFromLawyerSpecialityUI).ToList();
                    return await dbAccess.UpdateLawyerSpecialitiesAsync(lawyerSpecialities);
                }
                catch (Exception)
                {
                    return false;
                } 
            }
            return false;
        }

        public async Task<bool> DeleteLawyerSpecialitiesAsync(List<LawyerSpecialityUI> deletedLawyerSpecialities)
        {
            if (deletedLawyerSpecialities != null)
            {
                try
                {
                    List<LawyerSpeciality> lawyerSpecialities = deletedLawyerSpecialities
                                    .Select(modelConverter.ConvertFromLawyerSpecialityUI).ToList();
                    return await dbAccess.DeleteLawyerSpecialitiesAsync(lawyerSpecialities);
                }
                catch (Exception)
                {
                    return false;
                } 
            }
            return false;
        }
    }
}
