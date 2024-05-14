using DataAccess;
using EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIModels;

namespace BusinessLogic
{
    public class CaseServiceBL
    {
        ModelConverter modelConverter;
        CaseServiceDbAccess dbAccess;
        public CaseServiceBL() 
        { 
            modelConverter = new ModelConverter();
            dbAccess = new CaseServiceDbAccess();
        }

        public async Task<bool> CreateCaseServiceAsync(CaseServiceUI caseServiceUI)
        {
            CaseService temp = modelConverter.ConvertFromCaseServiceUI(caseServiceUI);
            return await dbAccess.CreateCaseServiceAsync(temp);
        }

        public async Task<List<CaseServiceUI>> GetCaseServicesAsync(int id)
        {
            List<CaseServiceUI> caseServicesUI = new List<CaseServiceUI>();

            foreach(CaseService caseService in await dbAccess.GetCaseServicesAsync(id))
            {
                caseServicesUI.Add(modelConverter.ConvertFromCaseServiceAndServiceEntity(caseService));
            }

            return caseServicesUI;
        }

        public async Task<List<CaseServiceUI>> GetCaseServicesForLawyerAsync(int id)
        {
            List<CaseService> caseServices = await dbAccess.GetCaseServicesForLawyerAsync(id);
            return caseServices.Select(modelConverter.ConvertFromCaseServiceAndServiceEntity).ToList();
        }

        public async Task<bool> UpdateCaseServicesAsync(CaseServiceUI caseServiceUI)
        {
            return await dbAccess.UpdateCaseServiceAsync(modelConverter.ConvertFromCaseServiceUI(caseServiceUI));
        }
    }

}
