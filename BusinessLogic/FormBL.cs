using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIModels;
using EntityModels;
using DataAccess;

namespace BusinessLogic
{
    public class FormBL
    {
        FormDbAccess dbAccess;
        ModelConverter modelConverter;
        public FormBL()
        {
            dbAccess = new FormDbAccess();
            modelConverter = new ModelConverter();
        }
        public async Task<List<FormUI>> GetFormAsync()
        {
            List<FormUI> formUIs = new List<FormUI>();

            foreach(Form form in await dbAccess.GetFormsAsync())
            {
                formUIs.Add(modelConverter.ConvertFromFormEntity(form));
            }

            return formUIs;
        }

        public async Task<List<FormUI>> GetBoughtFormsAsync(int clientID)
        {
            List<FormUI> boughtFormsUI = new List<FormUI>();
            foreach(Form form in await dbAccess.GetBoughtFormsAsync(clientID))
            {
                boughtFormsUI.Add(modelConverter.ConvertFromFormEntity(form));
            }
            return boughtFormsUI;
        }
    }
}
