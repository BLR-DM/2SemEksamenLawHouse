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
    public class CaseTypeBl
    {
        ModelConverter modelConverter;
        CaseTypeDbAccess dbAccess;
        public CaseTypeBl()
        {
            modelConverter = new ModelConverter();
            dbAccess = new CaseTypeDbAccess();
        }

        public async Task<List<CaseTypeUI>> GetCaseTypeAsync()
        {
            List<CaseType> caseTypesE = await dbAccess.GetCaseTypeAsync();
            List<CaseTypeUI> result = new List<CaseTypeUI>();

            foreach (CaseType caseType in caseTypesE)
            {
                result.Add(modelConverter.ConvertFromCaseTypeEntity(caseType));
            }

            return result;
        }

    }
}
