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
    public class FormularBL
    {
        FormularDbAccess dbAccess;
        ModelConverter modelConverter;
        public FormularBL()
        {
            dbAccess = new FormularDbAccess();
            modelConverter = new ModelConverter();
        }
        public async Task<List<FormularUI>> GetFormularsAsync()
        {
            List<FormularUI> formularUIs = new List<FormularUI>();

            foreach(Formular formular in await dbAccess.GetFormularsAsync())
            {
                formularUIs.Add(modelConverter.ConvertFromFormularEntity(formular));
            }

            return formularUIs;
        }
    }
}
