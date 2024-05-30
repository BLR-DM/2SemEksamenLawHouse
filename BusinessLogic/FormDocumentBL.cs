using UIModels;
using EntityModels;
using DataAccess;
using Interfaces;
using BusinessLogic.HelpServices;

namespace BusinessLogic
{
    public class FormDocumentBL
    {
        IFormDocumentDbAccess dbAccess;
        ModelConverter modelConverter;
        public FormDocumentBL()
        {
            dbAccess = new FormDocumentDbAccess();
            modelConverter = new ModelConverter();
        }
        public async Task<List<FormDocumentUI>> GetFormDocumentAsync()
        {
            List<FormDocumentUI> formUIs = new List<FormDocumentUI>();

            foreach(FormDocument form in await dbAccess.GetFormDocumentsAsync())
            {
                formUIs.Add(modelConverter.ConvertFromFormEntity(form));
            }

            return formUIs;
        }

        public async Task<List<FormDocumentUI>> GetBoughtFormDocumentsAsync(int clientID)
        {
            List<FormDocumentUI> boughtFormsUI = new List<FormDocumentUI>();
            foreach(FormDocument form in await dbAccess.GetBoughtFormDocumentsAsync(clientID))
            {
                boughtFormsUI.Add(modelConverter.ConvertFromFormEntity(form));
            }
            return boughtFormsUI;
        }

        public async Task<bool> CreateFormDocumentAsync(FormDocumentUI formUI)
        {
            FormDocument formToCreate = modelConverter.ConvertFromFormUI(formUI);
            return await dbAccess.CreateFormDocumentAsync(formToCreate);
        }

        public async Task<bool> UpdateFormDocumentAsync(FormDocumentUI formUI)
        {
            FormDocument formToUpdate = modelConverter.ConvertFromFormUI(formUI);
            return await dbAccess.UpdateFormDocumentAsync(formToUpdate);
        }

        public async Task<bool> DeleteFormDocumentAsync(FormDocumentUI formUI)
        {
            FormDocument formToDelete = modelConverter.ConvertFromFormUI(formUI);
            return await dbAccess.DeleteFormDocumentAsync(formToDelete);
        }
    }
}
