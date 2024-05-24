﻿using BusinessLogic.HelpServices;
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
    public class CaseTypeBL
    {
        ModelConverter modelConverter;
        ICaseTypeDbAccess dbAccess;
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

        public async Task<bool> CreateCaseTypeAsync(CaseTypeUI caseTypeUI)
        {
            return await dbAccess.CreateCaseTypeAsync(modelConverter.ConvertFromCaseTypeUI(caseTypeUI));
        }

        public async Task<bool> UpdateCaseTypeAsync(CaseTypeUI caseTypeUI)
        {
            return await dbAccess.UpdateCaseTypeAsync(modelConverter.ConvertFromCaseTypeUI(caseTypeUI));
        }

    }
}
