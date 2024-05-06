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
    public class CaseTypeBL
    {
        ModelConverter modelConverter;
        CaseTypeDbAccess dbAccess;
        public CaseTypeBL()
        {
            modelConverter = new ModelConverter();
            dbAccess = new CaseTypeDbAccess();
        }

        public async Task<List<CaseTypeUI>> GetCaseTypeAsync()
        {
            List<CaseTypeUI> result = new List<CaseTypeUI>();

            foreach (CaseType caseType in await dbAccess.GetCaseTypeAsync())
            {
                result.Add(modelConverter.ConvertFromCaseTypeEntity(caseType));
            }

            return result;
        }

    }
}
