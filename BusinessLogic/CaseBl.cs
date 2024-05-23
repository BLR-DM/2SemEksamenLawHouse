using BusinessLogic.HelpServices;
using DataAccess;
using EntityModels;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIModels;

namespace BusinessLogic
{
    public class CaseBL
    {
        ModelConverter modelConverter;
        ICaseDbAccess dbAccess;
        public CaseBL() 
        {
            modelConverter = new ModelConverter();
            dbAccess = new CaseDbAccess();
        }

        public async Task<bool> CreateCase(CaseUI caseUI)
        {
            Case temp = modelConverter.ConvertFromCaseUI(caseUI);
            return await dbAccess.CreateCaseAsync(temp);
        }

        public async Task<CaseUI> GetCaseAsync(int id)
        {
            return modelConverter.ConvertFromCaseEntity(await dbAccess.GetCaseAsync(id));
        }

        public async Task<CaseUI> GetCaseWithAllCollectionsAsync(int id)
        {
            Case caseE = await dbAccess.GetCaseWithAllCollectionsAsync(id);
            CaseUI caseUI = modelConverter.ConvertFromCaseEntityWithAllCollections(caseE);
            return caseUI;
        }

        public async Task<List<CaseUI>> GetCasesAsync()
        {
            List<CaseUI> cases = new List<CaseUI>();

            foreach(Case caseE in await dbAccess.GetCasesAsync())
            {
                cases.Add(modelConverter.ConvertFromCaseEntity(caseE));
            }

            return cases;
        }

        public async Task<List<CaseUI>> GetCasesAsync(int clientID)
        {
            List<CaseUI> cases = new List<CaseUI>();

            foreach(Case caseE in await dbAccess.GetCasesAsync(clientID))
            {
                cases.Add(modelConverter.ConvertFromCaseEntity(caseE));
            }
            return cases;
        }

        public async Task<bool> UpdateCaseSync(CaseUI caseUI)
        {
            Case temp = modelConverter.ConvertFromCaseUI(caseUI);
            return await dbAccess.UpdateCaseAsync(temp);
        }
    }
}
