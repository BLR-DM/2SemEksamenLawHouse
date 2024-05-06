﻿using DataAccess;
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

        public async Task<List<CaseServiceUI>> GetCaseServicesAsync()
        {
            List<CaseServiceUI> caseServicesUI = new List<CaseServiceUI>();

            foreach(CaseService caseService in await dbAccess.GetCaseServicesAsync())
            {
                caseServicesUI.Add(modelConverter.ConvertFromCaseServiceEntity(caseService));
            }

            return caseServicesUI;
        }
    }

}
