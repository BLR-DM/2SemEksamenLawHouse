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
    public class CaseBl
    {
        ModelConverter modelConverter;
        CaseDbAccess dbAccess;
        public CaseBl() 
        {
            modelConverter = new ModelConverter();
            dbAccess = new CaseDbAccess();
        }

        public async Task<bool> CreateCase(CaseUI caseUI)
        {
            Case temp = modelConverter.ConvertFromCaseUI(caseUI);
            return await dbAccess.CreateCase(temp);
        }
    }
}
